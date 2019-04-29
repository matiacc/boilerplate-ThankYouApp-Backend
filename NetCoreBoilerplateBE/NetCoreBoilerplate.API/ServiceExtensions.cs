using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreBoilerplate.Contracts;
using NetCoreBoilerplate.Entities;
using NetCoreBoilerplate.Repository;

namespace NetCoreBoilerplate.API
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:FirstExampleDB"];
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}