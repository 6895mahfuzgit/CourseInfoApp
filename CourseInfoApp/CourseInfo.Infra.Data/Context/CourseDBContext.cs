using CourseInfo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseInfo.Infra.Data.Context
{
    public class CourseDBContext : DbContext
    {
        public CourseDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses{ get; set; }
    }
}
