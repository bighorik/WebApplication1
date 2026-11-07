using Application.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddNpgsql<ApplicationContext>("...ConnectionString...");
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();

            return services;
        }
    }
}
