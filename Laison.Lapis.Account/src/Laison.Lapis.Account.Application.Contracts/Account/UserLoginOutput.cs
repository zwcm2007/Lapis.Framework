namespace Laison.Lapis.Account.Application.Contracts
{
    public class UserLoginOutput
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户简介
        /// </summary>
        public ProfileDto Profile { get; set; }
    }
}