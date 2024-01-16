using Exam21.Business.Repositories.Implements;
using Exam21.Business.Repositories.Interfaces;
using Exam21.Business.Services.Implements;
using Exam21.Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Exam21.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPortfolioService, PortfolioService>();
            return services;
        }
    }
}
