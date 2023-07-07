using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Services.AppServices;

public interface IAuthService
{
    Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName);
    Task<bool> CheckPasswordAsync(AppUser user, string password);
    Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId);
    Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId);
}
