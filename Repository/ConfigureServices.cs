using Application.Interfaces.Repository.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Generic;

namespace Repository
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {

            #region |Context|
            services.AddDbContext<ApplicationDbContext>(options =>
               options
               .UseLazyLoadingProxies()
               .UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection"),
                   builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
               );

            services.AddScoped<ApplicationDbContextInitialiser>();
            #endregion

            services.AddScoped<ApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IGenericRepository<Schedule>, GenericRepository<Schedule>>();
            services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();


            return services;
        }
    }
}