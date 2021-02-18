using Microsoft.EntityFrameworkCore;
using OnlineCoursePortal.Models;

namespace OnlineCoursePortal.Data
{
    public class OnlineCoursePortalContext : DbContext
    {
        public OnlineCoursePortalContext(DbContextOptions<OnlineCoursePortalContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }
        public DbSet<Faculty> Faculty { get; set; }        
        public DbSet<OnlineCoursePortal.Models.User> User { get; set; }

    }
}