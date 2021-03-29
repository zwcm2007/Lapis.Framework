using IdentityModel;
using Laison.Lapis.HttpApi.Shared;
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

        [HttpGet("HasException")]
        public void Get2Async()
        {
            //throw new BusinessException("1001", "我是业务异常");
            throw new UserFriendlyException("我是友好异常", "1002");
        }

        //[Authorize]
        [HttpGet("HasResult")]
        public ReturnResult Get3Async()
        {
            return new ReturnResult
            {
                Name = "冯珏庆",
                Address = "朝晖九区"
            };
            // var userId = _principalAccessor.Principal.FindFirst(c => c.Type == AbpClaimTypes.UserId)?.Value;
            //return userId;
        }

        [Route("token")]
        [HttpGet]
        public string GetToken()
        {
            var token = GenerateJwt("JwtBearerSample_11231~#$%#%^2235",
                    new Claim(AbpClaimTypes.UserId, "1"),
                    new Claim(AbpClaimTypes.UserName, "fjq"),
                    new Claim(AbpClaimTypes.PhoneNumber, "18668180673"),
                    new Claim(AbpClaimTypes.Email, "180489097@qq.com"),
                    //new Claim("orgid", user.ORGID),
                    new Claim(JwtClaimTypes.Issuer, "DangKe"),
                    new Claim(JwtClaimTypes.Audience, "Audience")
                    );

            return token;
        }

        private string GenerateJwt(string key, params Claim[] claims)
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

    public class ReturnResult
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }
}