using Exam21.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Exam21.DAL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddSql(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<Exam21DbContext>(opt =>
            {
                opt.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
