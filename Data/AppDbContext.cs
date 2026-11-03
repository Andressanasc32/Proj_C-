using Microsoft.EntityFrameworkCore;
using ProjWeb.Domain;

namespace ProjWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options){}

        public DbSet<User>BD_USER{get; set;}
    }
}