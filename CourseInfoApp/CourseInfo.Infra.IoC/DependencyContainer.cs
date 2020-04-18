using CourseInfo.Application.Interfaces;
using CourseInfo.Application.Services;
using CourseInfo.Domain.Interfaces;
using CourseInfo.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CourseInfo.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterSercvices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            


        }
    }
}
