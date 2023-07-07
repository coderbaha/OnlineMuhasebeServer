using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public interface IServiceInstaller
    {
        void Install(IServiceCollection services, IConfiguration configuration);
    }
}
