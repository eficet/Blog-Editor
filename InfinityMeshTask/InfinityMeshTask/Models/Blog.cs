using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InfinityMeshTask.Models
{
    public class Blog
    {
        public int blogId{ get; set; }

        [Required,StringLength(64)]
        public string title { get; set; }

        [Required, StringLength(350)]
        public string summary { get; set; }

        [Required, StringLength(3500)]
        public string content { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? publishDate { get; set; }

        // Foriegn key from User table
        public int userId { get; set; } 
        public User user { get; set; }
    }
}