using CourseInfo.Domain.Interfaces;
using CourseInfo.Domain.Models;
using CourseInfo.Infra.Data.Context;
using System.Collections.Generic;

namespace CourseInfo.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseDBContext _context;

        public CourseRepository(CourseDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
