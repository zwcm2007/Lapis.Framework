using Laison.Lapis.Account.Application.Contracts;
using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.Account.Application
{
    /// <summary>
    /// 账号应用服务
    /// </summary>
    public class AccountAppService : AccountAppServiceBase, IAccountAppService
    {
        private readonly IUserRepository _userRepository;

        public AccountAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserLoginOutput> LoginAsync(UserLoginInput input)
        {
            var user = await _userRepository.GetUserAsync(input.UserName);
            if (user == null)
            {
                throw new BusinessException("登录用户不存在");
            }

            if (user.p != input.Password.ToMd5())
            {
                throw new UserFriendlyException("密码不正确");
            }

            return new UserLoginOutput
            {
                AccessToken = GenerateJwt(user),
                Profile = ObjectMapper.Map<User, ProfileDto>(user)
            };
        }

        private string GenerateJwt(User user)
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

        public Task ResetPasswordAsync(ResetPasswordDto input)
        {
            throw new NotImplementedException();
        }
    }
}