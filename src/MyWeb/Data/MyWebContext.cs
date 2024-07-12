using Microsoft.EntityFrameworkCore;
using MyWeb.Models;

namespace MyWeb.Data
{
    public class MyWebContext : DbContext
    {
        public MyWebContext(DbContextOptions<MyWebContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // You can add additional configuration here if needed
        }
    }
}
