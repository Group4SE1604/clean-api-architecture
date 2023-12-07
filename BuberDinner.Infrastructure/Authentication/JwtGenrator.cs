using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Interfaces.Auth;
using BuberDinner.Application.Common.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

namespace BuberDinner.Infrastructure.Authentication
{
    public class JwtGenrator : IJwtGenerator
    {
        private readonly JwtSettings _jwtSettings;

        private readonly IDatetimeProivder _datetimeProivder;

        public JwtGenrator(IDatetimeProivder datetimeProivder, IOptions<JwtSettings> jwtOptions)
        {
            _datetimeProivder = datetimeProivder;
            _jwtSettings = jwtOptions.Value;
        }

        public string GenrateToken(Guid userId, string firstName, string lastName)
        {
            var sercurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var signingCredentials = new SigningCredentials(sercurityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub , userId.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName , firstName),
                new Claim(JwtRegisteredClaimNames.FamilyName , lastName),
                new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString()),

        };
            var sercurityToken = new JwtSecurityToken(issuer: _jwtSettings.Issuer,
             expires: _datetimeProivder.UtcNow.AddDays(_jwtSettings.ExpirationsDays),
             audience: _jwtSettings.Audience,
             signingCredentials: signingCredentials, claims: claims);


            return new JwtSecurityTokenHandler().WriteToken(sercurityToken);
        }
    }
}