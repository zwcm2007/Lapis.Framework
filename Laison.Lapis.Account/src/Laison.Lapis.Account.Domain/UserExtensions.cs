using Laison.Lapis.Identity.Domain.Entities;
using Volo.Abp.Data;

namespace Laison.Lapis.Account.Domain
{
    public static class UserExtensions
    {
        private const string CityPropertyName = "City";

        private const string CountryPropertyName = "Country";

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="user"></param>
        /// <param name="currentPassword"></param>
        /// <returns></returns>
        public static bool CheckPassword(this User user, string currentPassword)
        {
            var city = user.GetCity();
            user.SetCity("ShangHai");

            return user.Password == currentPassword;
        }

        public static void SetCity(this User user, string city)
        {
            user.SetProperty(CityPropertyName, city);
        }

        public static string GetCity(this User user)
        {
            return user.GetProperty<string>(CityPropertyName);
        }
    }
}