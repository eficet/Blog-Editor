using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InfinityMeshTask.Models
{
    public class User
    {
        public int userId { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string email { get; set; }

        //A list of blog that indicates the 1 to many relationship between my two tables
        public List<Blog> blogs { get; set; }
    }
}