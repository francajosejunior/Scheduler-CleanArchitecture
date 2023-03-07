using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options
               .UseLazyLoadingProxies()
               .UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection"),
                   builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
               );

            services.AddScoped<ApplicationDbContextInitialiser>();



            return services;
        }
    }
}