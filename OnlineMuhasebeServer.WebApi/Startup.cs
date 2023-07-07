using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.WebApi.Configurations;
using OnlineMuhasebeServer.WebApi.Middleware;
using System;
using System.Linq;

namespace OnlineMuhasebeServer.WebApi
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
            services.InstallServices(Configuration, typeof(IServiceInstaller).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OnlineMuhasebeServer.WebApi v1"));
            }
            /*user tablosu boþ ise default kullanýcý ekler*/
            using (var scoped = app.ApplicationServices.CreateScope())
            {
                var user = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                if (!user.Users.Any())
                {
                    var t = user.CreateAsync(new AppUser()
                    {
                        UserName = "BahadirAsik",
                        Email = "test@gmail.com",
                        Id = Guid.NewGuid().ToString(),
                        NameLastName = "Bahadýr Aþýk",
                        EmailConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnabled = false,
                        PhoneNumberConfirmed = false,
                        PhoneNumber = "",
                        AccessFailedCount = 0,
                    }, "Password12*").Result;
                }
            }
            app.UseHttpsRedirection();
            app.UseExceptionMiddleware();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
