using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreCodeFirstApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }
    }
}
