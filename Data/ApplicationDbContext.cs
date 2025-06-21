using Microsoft.EntityFrameworkCore;
using StudentTimeProject.Data.Entities;

namespace StudentTimeProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentTime> StudentTimes { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Student>().ToTable("Students");
            builder.Entity<StudentTime>().ToTable("StudentTimes");
            builder.Entity<StudentClass>().ToTable("StudentClasses");
        }
    }
}