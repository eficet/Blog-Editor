using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InfinityMeshTask.Models.Database
{
    public class MyDatabase:DbContext 
    {
        public MyDatabase() // dbcontext constructor
            : base("name=MyDatabase")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<User> users { get; set; }
        public DbSet<Blog> blogs { get; set; }

    }
}