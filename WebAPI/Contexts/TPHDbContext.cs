using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebAPI.Entities;

namespace WebAPI.Contexts
{
    public class TPHDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-SS5IP2IG\\SQLEXPRESS;Database=TPHDb;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
