using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OnlineMuhasebeServer.WebApi.Middleware;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class PresentationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ExceptionMiddleware>();
            services.AddCors(options => options.AddDefaultPolicy(options =>
            {
                options.AllowAnyHeader().AllowAnyMethod().AllowCredentials()
                .SetIsOriginAllowed(options => true);
            }));
            services.AddControllers().AddApplicationPart(typeof(Persistance.AssemblyReference).Assembly);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OnlineMuhasebeServer.WebApi", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = JwtBearerDefaults.AuthenticationScheme
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id= JwtBearerDefaults.AuthenticationScheme
                            }
                        },
                        new string[]{}
                    }
                });
            });
        }
    }
}
