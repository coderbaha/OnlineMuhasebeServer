using OnlineMuhasebeServer.Domain.AppEntities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Services.AppServices;

public interface IMainRoleAndRoleRelationshipService
{
    Task CreateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship, CancellationToken cancellationToken);
    Task UpdateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship);
    Task RemoveByIdAsync(string id);
    IQueryable<MainRoleAndRoleRelationship> GetAll();
    Task<MainRoleAndRoleRelationship> GetByIdAsync(string id);
    Task<IList<MainRoleAndRoleRelationship>> GetListByMainRoleIdForGetRolesAsync(string id);
    Task<MainRoleAndRoleRelationship> GetByRoleIdAndMainRoleId(string roleId, string mainRoleId, CancellationToken cancellationToken = default);
}
