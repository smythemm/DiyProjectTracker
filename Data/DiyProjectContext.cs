using Microsoft.EntityFrameworkCore;

namespace DiyProjectTracker.Data
{
    public class DiyProjectContext : DbContext
    {
        public DiyProjectContext(DbContextOptions<DiyProjectContext> options) : base(options)
        {
        }

        public DbSet<DiyProject> DiyProjects { get; set; }
        
    }
}