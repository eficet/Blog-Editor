using InfinityMeshTask.Models;
using InfinityMeshTask.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Data.Entity;

namespace InfinityMeshTask.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BlogController : ApiController
    {
        MyDatabase db = new MyDatabase();
        public IHttpActionResult GetAll()
        {
            var data = db.blogs.ToList();
            return Ok(data);
        }
        [Route("api/blogs/{id}")]
        public IHttpActionResult GetByUserId(int id)
        {
            if (id == 0 || id > db.users.Count())
            {
                BadRequest("Your id is wrong");
            }

            try
            {
                var data = db.blogs.Where(s => s.userId == id).OrderBy(v => v.publishDate).ToList();
                return Ok(data);
            }
            catch (Exception)
            {
                return NotFound();
            }
           
        }
        [Route("api/blog/{id}")]
        public IHttpActionResult GetByBloId(int id)
        {
            if (id == 0 || id > db.blogs.Count())
            {
                BadRequest("Your id is wrong");
            }

            try
            {
                var data = db.blogs.Where(s => s.blogId == id);
                return Ok(data);
            }
            catch(Exception)
            {
                return NotFound();
            }
            
        }
        
        [AcceptVerbs("PUT", "POST")]
        [Route("api/blog", Name = "PostBlog")]
        public IHttpActionResult PostUser(Blog blog)
        {
            var methodType = this.Request.Method;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (blog.userId < 1)
            {
                return BadRequest();
            }
            if (blog.blogId == 0 && methodType == HttpMethod.Post)
            {
                try
                {
                    db.blogs.Add(blog);
                    db.SaveChanges();
                    return CreatedAtRoute("PostBlog", new { id = blog.userId }, blog);
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            else
            {
                if (blog.userId > db.users.Count())
                {
                    return BadRequest("User dosent exist");
                }
                if (methodType == HttpMethod.Put&& blog.blogId>0)
                {

                    var myBlog = db.blogs.Where(b => b.blogId == blog.blogId).FirstOrDefault<Blog>();
                    myBlog.title = blog.title;
                    myBlog.summary = blog.summary;
                    myBlog.publishDate = blog.publishDate;
                    myBlog.content = blog.content;
                    db.SaveChanges();
                    return StatusCode(HttpStatusCode.Created);
                }
                return BadRequest();
                
            }

        }
        [Route("api/blogs/{id}")]
        [HttpGet]
        public IHttpActionResult GetBetweenDates(long startDate,long endDate,int id)
        {
            if (id==0||id>db.users.Count()){
                BadRequest("Your id is wrong");
            }
            try
            {
                var timeStart = DateTimeOffset.FromUnixTimeMilliseconds(startDate);
                var timeEnd = DateTimeOffset.FromUnixTimeMilliseconds(endDate);
                var toStart = timeStart.ToString();
                var toEnd = timeEnd.ToString();
                var start = DateTime.Parse(toStart);
                var end = DateTime.Parse(toEnd);
                var data = db.blogs.Where(b => b.publishDate > start && b.publishDate < end);
                var filteredData = data.Where(b => b.userId == id).ToList();
                return Ok(filteredData);
            }
            catch(Exception)
            {
                return NotFound();
            }
        }

    }
}
    