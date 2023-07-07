using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineMuhasebeServer.WebApi.OptionsSetup;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class AuthenticationAndAuthorizationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<JwtOptionsSetup>();
            services.ConfigureOptions<JwtBearerOptionsSetup>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).
                AddJwtBearer();
        }
    }
}
