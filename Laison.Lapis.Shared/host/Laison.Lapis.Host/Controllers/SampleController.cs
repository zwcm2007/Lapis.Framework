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
        /// �����޽��������
        /// </summary>
        [HttpGet("NoResult")]
        public void GetAsync()
        {
            var a = Configuration["Jwt:IssuerSigningKey"].ToString();
        }

        /// <summary>
        /// �����н��������
        /// </summary>
        /// <returns></returns>
        [HttpGet("HasResult")]
        public dynamic Get2Async()
        {
            return new
            {
                Name = "������",
                Sex = "��",
                Favorite = "����"
            };
        }

        /// <summary>
        /// �׳��쳣
        /// </summary>
        [HttpGet("ThrowException")]
        public void Get3Async()
        {
            throw new UserFriendlyException("�����Ѻ��쳣", "1002");
        }

        /// <summary>
        /// ��Ҫ��Ȩ����
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
        /// ��ȡJWT����
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
                    new Claim(AbpClaimTypes.Name, "������"),
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