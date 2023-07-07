using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Persistance;
using OnlineMuhasebeServer.Persistance.Context;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class PersistanceServiceInstaller : IServiceInstaller
    {
        private const string _sectionName = "SqlServer";
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(_sectionName)));

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddAutoMapper(typeof(AssemblyReference).Assembly);
        }
    }
}
