using CourseInfo.Application.Interfaces;
using CourseInfo.Application.ViewModels;
using CourseInfo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseInfo.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCources()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
