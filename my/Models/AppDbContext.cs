using Microsoft.EntityFrameworkCore;
using my.Models;
namespace my.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}