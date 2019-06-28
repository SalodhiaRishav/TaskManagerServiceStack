using DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL.Database
{
    public class DatabaseContext : DbContext
    {
        
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {
                
            }

            
            public DbSet<User> Users { get; set; }
            public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
