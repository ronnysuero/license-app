using System;
using DataProvider.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataProvider.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataProvider<TDbContext, TDbFactory>(
            this IServiceCollection service, Action<DbContextOptionsBuilder> optionsActions)
            where TDbContext : LicenseDbContext
            where TDbFactory : IDbFactory

        {
            service.AddDbContext<TDbContext>(optionsActions);
            service.AddScoped(typeof(IDbFactory), typeof(TDbFactory));

            return service;
        }
    }
}