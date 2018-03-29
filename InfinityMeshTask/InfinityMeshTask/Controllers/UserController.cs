using InfinityMeshTask.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Data.Entity;
using InfinityMeshTask.Models;

namespace InfinityMeshTask.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        MyDatabase db = new MyDatabase();

        [Route("api/users")]
        public IHttpActionResult GetHome()
        {
            try { 
            const int pageSize = 5;
            var data = db.users.Include(b => b.blogs);
            var mydata = data.OrderBy(c => c.userId).Skip(0).Take(pageSize).ToList();
                return Ok(mydata);
            }
            catch
            {
                return (NotFound());
            }
            
        }
        [Route("api/users/count")]
        public IHttpActionResult GetCount()
        {
            try
            {
                var data = db.users.Include(b => b.blogs);

                return Ok(data.Count());
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [Route("api/page/{page}")]
        public IHttpActionResult GetByPage(int page)
        {

            if (page < 1) {

                return (BadRequest());
            }
            try
            {
                const int pageSize = 5;

                //get users including their blogs
                var data = db.users.Include(b => b.blogs);

                //Paggination
                var mydata = data.OrderBy(c => c.userId).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                //return sorted by

                return Ok(mydata.OrderBy(c => c.name));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [Route("api/users/{name}")]
        [HttpGet]
        public IHttpActionResult filterByNameAndMail(string name)
        {

            
            if (name==null||name=="") {
                return (BadRequest());
            }
            try
            {
                var filteredData = db.users.Where((s => (s.name.ToLower().Contains(name.ToLower())) || (s.email.ToLower().Contains(name.ToLower()))));
                if (filteredData == null||filteredData.Count()==0) {
                    return NotFound();
                }
                return Ok(filteredData);
            }
            catch
            {
                return NotFound();
            }
    }

        public IHttpActionResult GetProfile(int id)
        {
            if (id > db.users.Count())
            {
                return BadRequest("User doesnt exist");
            }
            
            //select user by id and include his all blogs and sort them by date
            var data = db.users.Where(b => b.userId == id);
            if (data == null||data.Count()==0)
            {
                return NotFound();
            }

            return Ok(data);
        }
        [AcceptVerbs("PUT","POST")]
        public IHttpActionResult PostUser([FromBody]User  user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (user.userId < 1)
            {
                return BadRequest();
            }
            if (user.userId == 0)
            {
                try { 
                db.users.Add(user);
                db.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = user.userId }, user);
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            else
            {
                if (user.userId > db.users.Count())
                {
                    return BadRequest("User dosent exist");
                }
                db.users.Add(user);
                    db.SaveChanges();
                return StatusCode(HttpStatusCode.Created);
            }
        }
    }

}
