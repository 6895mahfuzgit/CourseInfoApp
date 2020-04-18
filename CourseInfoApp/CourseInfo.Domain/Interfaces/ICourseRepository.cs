using CourseInfo.Domain.Models;
using System.Collections.Generic;

namespace CourseInfo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
