using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;
using WebApplication1.Context.Configur;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new StudentConfiguration().Configure(modelBuilder.Entity<Student>());
            new StateConfiguration().Configure(modelBuilder.Entity<State>());
            new ProfessorConfiguration().Configure(modelBuilder.Entity<Professor>());
            new LessonConfiguration().Configure(modelBuilder.Entity<Lesson>());
            new AddressConfiguration().Configure(modelBuilder.Entity<Address>());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
