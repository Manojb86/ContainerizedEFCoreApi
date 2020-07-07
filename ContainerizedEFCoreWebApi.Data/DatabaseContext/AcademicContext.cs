using ContainerizedEFCoreWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ContainerizedEFCoreWebApi.Data.DatabaseContext
{
    public class AcademicContext : DbContext
    {
        public AcademicContext(DbContextOptions<AcademicContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 1, FirstName = "Manoj", LastName = "Bandara", Age = 30, Email = "manojb@gmail.com" });
        }
    }
}
