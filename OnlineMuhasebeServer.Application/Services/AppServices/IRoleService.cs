using OnlineMuhasebeServer.Application.Features.RoleFeatures.Commands.CreateRole;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Services.AppServices
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleCommand request);
        Task AddRangeAsync(IEnumerable<AppRole> roles);
        Task UpdateAsync(AppRole role);
        Task DeleteAsync(AppRole role);
        Task<IList<AppRole>> GetAllRolesAsync();
        Task<AppRole> GetById(string id);
        Task<AppRole> GetByCode(string code);
    }
}
