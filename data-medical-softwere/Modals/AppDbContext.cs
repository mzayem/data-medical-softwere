using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace YourApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
    }
}