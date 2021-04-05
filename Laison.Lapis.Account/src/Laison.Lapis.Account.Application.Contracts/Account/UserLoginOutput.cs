namespace Laison.Lapis.Account.Application.Contracts
{
    public class UserLoginOutput
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        public UserDto UserInfo { get; set; }
    }
}