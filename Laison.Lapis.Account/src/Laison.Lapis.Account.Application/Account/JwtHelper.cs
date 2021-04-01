using Laison.Lapis.Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laison.Lapis.Account.Application
{
    public static class JwtHelper
    {
        private string GenerateJwtForUser(User user)
        {
            return null;
            //var key = Configuration["Jwt:IssuerSigningKey"];
            //var issuer = Configuration["Jwt:ValidIssuer"];
            //var audience = Configuration["Jwt:ValidAudience"];
            //var hours = Convert.ToInt32(Configuration["Jwt:ValidHours"]);

            //var claims = new List<Claim>()
            //{
            //    new Claim(AbpClaimTypes.UserId, user.Id.ToString()),
            //    new Claim(AbpClaimTypes.UserName, user.Name ?? "未知"),
            //    new Claim("AccountId", user.AccountId),
            //    new Claim(AbpClaimTypes.PhoneNumber, user.Mobile ?? ""),
            //    new Claim(AbpClaimTypes.Email, user.Email?? ""),
            //    new Claim(JwtClaimTypes.Issuer, issuer),
            //    new Claim(JwtClaimTypes.Audience, audience)
            //};

            //var tokenHandler = new JwtSecurityTokenHandler();
            //var expiresAt = DateTime.UtcNow.AddHours(hours);
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(claims),
            //    Expires = expiresAt,
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)), SecurityAlgorithms.HmacSha256Signature)
            //};

            //var token = tokenHandler.CreateToken(tokenDescriptor);
            //var tokenString = tokenHandler.WriteToken(token);
            //return tokenString;
        }
    }
}
