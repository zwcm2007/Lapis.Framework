using IdentityModel;
using Laison.Lapis.Shared.HttpApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Volo.Abp;
using Volo.Abp.Security.Claims;

namespace Laison.Lapis.Host
{
    [Route("api/sample")]
    [ApiExplorerSettings(GroupName = "User")]
    public class SampleController : LapisController
    {
        private readonly ICurrentPrincipalAccessor _principalAccessor;

        public SampleController(ICurrentPrincipalAccessor principalAccessor)
        {
            _principalAccessor = principalAccessor;
        }

        /// <summary>
        /// 返回无结果的数据
        /// </summary>
        [HttpGet("NoResult")]
        public void GetAsync()
        {
            var a = Configuration["Jwt:IssuerSigningKey"].ToString();
        }

        /// <summary>
        /// 返回有结果的数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("HasResult")]
        public dynamic Get2Async()
        {
            return new
            {
                Name = "冯珏庆",
                Sex = "男",
                Favorite = "旅游"
            };
        }

        /// <summary>
        /// 抛出异常
        /// </summary>
        [HttpGet("ThrowException")]
        public void Get3Async()
        {
            throw new UserFriendlyException("我是友好异常", "1002");
        }

        /// <summary>
        /// 需要授权操作
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost("AuthorizedOperation")]
        public string Get4Async()
        {
            //var userId = _principalAccessor.Principal.FindFirst(c => c.Type == AbpClaimTypes.UserId)?.Value;
            var userId = CurrentUser.Id;
            return userId?.ToString() ?? "";
        }

        /// <summary>
        /// 获取JWT令牌
        /// </summary>
        /// <returns></returns>
        [Route("JwtToken")]
        [HttpGet]
        public string GetToken()
        {
            var token = GenerateJwt("JwtBearerSample_11231~#$%#%^2235",
                    new Claim(AbpClaimTypes.UserId, "1"),  //id
                    new Claim(AbpClaimTypes.TenantId, "2"),
                    new Claim(AbpClaimTypes.UserName, "admin"),
                    new Claim(AbpClaimTypes.Name, "冯珏庆"),
                    new Claim(AbpClaimTypes.PhoneNumber, "18668180673"),
                    new Claim(AbpClaimTypes.Email, "180489097@qq.com"),
                    new Claim(JwtClaimTypes.Issuer, "Laison"),
                    new Claim(JwtClaimTypes.Audience, "Audience")
                    );

            return token;

            static string GenerateJwt(string key, params Claim[] claims)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var expiresAt = DateTime.UtcNow.AddHours(12);   //authTime.AddSeconds(30);
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
}