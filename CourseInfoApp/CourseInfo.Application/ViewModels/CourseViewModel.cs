using CourseInfo.Domain.Models;
using System.Collections.Generic;

namespace CourseInfo.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
