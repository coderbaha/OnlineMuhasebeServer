using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.Dtos;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser appUser/*, List<string> roles*/);
    }
}
