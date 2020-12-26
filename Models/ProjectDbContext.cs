using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HoustonPD.Models
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
        }
        public DbSet<User> Users { get; set; }

    }
}