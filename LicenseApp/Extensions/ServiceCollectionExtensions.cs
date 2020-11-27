using System;
using DataProvider;
using DataProvider.Extensions;
using DataProvider.Interfaces;
using DataProvider.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LicenseApp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreDataProvider<TDbContext, TDbFactory>(
            this IServiceCollection services,
            Action<DbContextOptionsBuilder> optionsActions
        )
            where TDbContext : LicenseDbContext
            where TDbFactory : IDbFactory
        {
            services.AddDataProvider<TDbContext, TDbFactory>(optionsActions);
            services.AddScoped(typeof(IDbFactory), typeof(TDbFactory));

            return services;
        }

        public static IServiceCollection AddCoreSqlDataProvider(this IServiceCollection services,
            string connectionString)

        {
            services.AddCoreDataProvider<MsSqlServerDb, MsSqlFactory>(builder =>
                builder.UseSqlServer(connectionString)
            );

            return services;
        }
    }
}