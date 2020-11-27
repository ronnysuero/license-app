using Autofac;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using DataProvider.Interfaces;
using Hellang.Middleware.ProblemDetails;
using LicenseApp.Extensions;
using LicenseApp.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using VueCliMiddleware;

namespace LicenseApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(opt =>
                    opt.SerializerSettings.ContractResolver = new DefaultContractResolver()
                );

            services.AddProblemDetails(options => options.IncludeExceptionDetails = (ctx, ex) => true);
            services.AddCoreSqlDataProvider(Configuration.GetSection("ConnectionStrings")["Local"]);

            var mappingConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddCollectionMappers();
                cfg.AddProfile(new MappingProfile());
            });

            services.AddSingleton(mappingConfig.CreateMapper());
            services.AddSwaggerGen();
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "clientapp"; });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            // Add any Autofac modules or registrations.
            // This is called AFTER ConfigureServices so things you
            // register here OVERRIDE things registered in ConfigureServices.
            //
            // You must have the call to `UseServiceProviderFactory(new AutofacServiceProviderFactory())`
            // when building the host or this won't be called.
            builder.RegisterModule(new AutofacModule());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseProblemDetails();
            app.UseRouting();
            app.UseSwagger();
            app.UseSpaStaticFiles();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var factory = serviceScope.ServiceProvider.GetRequiredService<IDbFactory>();
                factory.Db.Database.Migrate();
            }

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "License App V1"));

            app.UseEndpoints(endpoints => endpoints.MapControllers());

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = env.IsDevelopment() ? "clientapp" : "dist";

                if (env.IsDevelopment())
                {
                    spa.UseVueCli("serve");
                }
            });
        }
    }
}