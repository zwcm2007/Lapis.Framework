using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using Volo.Abp.Security.Claims;

namespace Laison.Lapis.Shared.Host
{
    public static class AuthenticationServiceCollectionExtensions
    {
        /// <summary>
        /// 添加JWT认证
        /// </summary>
        /// <param name="services"></param>
        /// <param name="signingKey"></param>
        /// <param name="validIssuer"></param>
        /// <param name="validAudience"></param>
        /// <returns></returns>
        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, string signingKey, string validIssuer, string validAudience)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(o =>
           {
               o.TokenValidationParameters = new TokenValidationParameters
               {
                   NameClaimType = AbpClaimTypes.UserName,
                   RoleClaimType = AbpClaimTypes.Role,
                   ValidAudience = validAudience,
                   ValidateAudience = false,
                   ValidIssuer = validIssuer,
                   ValidateIssuer = false,
                   ValidateLifetime = true,
                   ClockSkew = TimeSpan.FromSeconds(30),
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey))
               };
           });

            return services;
        }
    }
}