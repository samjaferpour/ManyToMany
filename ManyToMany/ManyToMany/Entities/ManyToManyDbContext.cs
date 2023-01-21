using ManyToMany.EntityConfigs;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Entities
{
    public class ManyToManyDbContext : DbContext
    {
        public ManyToManyDbContext(DbContextOptions<ManyToManyDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> Studentourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new StudentCourseConfig());
        }
    }
}
