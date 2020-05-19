using DotnetCoreWebApplication.Repository;
using DotnetCoreWebApplication.Repository.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotnetCoreWebApplication
{
    public class Startup
    {
        private readonly string _allowOrigins = "AllowOrigins";
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(_allowOrigins,
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader() 
                        .WithHeaders()
                        .AllowAnyMethod());
            });
            
            services.AddControllers();
            services.AddScoped<IUserStateRepository, MockUserStateRepository>();
            services.AddScoped<IUserRepository, MockUserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(_allowOrigins);
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}