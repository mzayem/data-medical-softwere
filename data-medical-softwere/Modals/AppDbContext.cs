using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace data_medical_softwere.Modals
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Division> Divisions { get; set; }
    }
}