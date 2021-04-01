using IdentityModel;
using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Volo.Abp.Security.Claims;

namespace Laison.Lapis.Account.Application
{
    public static class JwtHelper
    {
        public static string GenerateToken(User user, IConfiguration Configuration)
        {
            var key = Configuration["Jwt:IssuerSigningKey"];
            var issuer = Configuration["Jwt:ValidIssuer"];
            var audience = Configuration["Jwt:ValidAudience"];
            var hours = Convert.ToInt32(Configuration["Jwt:ValidHours"]);

            var claims = new List<Claim>()
            {
                new Claim(AbpClaimTypes.UserId, user.Id.ToString()),
                new Claim(AbpClaimTypes.UserName, user.UserName),
                new Claim(AbpClaimTypes.Name, user.Name ?? "") ,
                new Claim(AbpClaimTypes.PhoneNumber, user.PhoneNumber ?? ""),
                new Claim(AbpClaimTypes.Email, user.Email?? ""),
                new Claim(JwtClaimTypes.Issuer, issuer),
                new Claim(JwtClaimTypes.Audience, audience)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var expiresAt = DateTime.UtcNow.AddHours(hours);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = expiresAt,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}