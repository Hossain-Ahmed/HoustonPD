
using System.Data.Entity;

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