using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.Dtos;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Infrasturcture.Authentication
{
    public sealed class JwtProvider : IJwtProvider
    {
        private readonly JwtOptions _jwtOptions;
        private readonly UserManager<AppUser> _userManager;
        public JwtProvider(IOptions<JwtOptions> jwtOptions, UserManager<AppUser> userManager)
        {
            _jwtOptions = jwtOptions.Value;
            _userManager = userManager;
        }
        public async Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser appUser/*, List<string> roles*/)
        {
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,appUser.NameLastName),
                new Claim(JwtRegisteredClaimNames.Email,appUser.Email),
                new Claim(ClaimTypes.Authentication,appUser.Id),
                //new Claim(ClaimTypes.Role,string.Join(",",roles)),
            };
            DateTime expires = DateTime.Now.AddDays(1);
            JwtSecurityToken jwtSecurityToken = new(
                issuer: _jwtOptions.Issuer,
                audience: _jwtOptions.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: expires,
                signingCredentials: new SigningCredentials
                (new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)), SecurityAlgorithms.HmacSha256)
                );
            var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            var refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
            appUser.RefreshToken = refreshToken;
            appUser.RefreshTokenExpires = expires.AddMinutes(60);
            await _userManager.UpdateAsync(appUser);
            return new(token, appUser.RefreshToken, appUser.RefreshTokenExpires);
        }
    }
}
