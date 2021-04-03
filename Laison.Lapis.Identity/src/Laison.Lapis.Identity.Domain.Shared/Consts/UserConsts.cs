namespace Laison.Lapis.Identity.Domain.Shared
{
    public class UserConsts
    {
        /// <summary>
        /// Default value: 256
        /// </summary>
        public static int MaxUserNameLength { get; set; } = 256;

        /// <summary>
        /// Default value: 64
        /// </summary>
        public static int MaxNameLength { get; set; } = 64;

        /// <summary>
        /// Default value: 64
        /// </summary>
        public static int MaxSurnameLength { get; set; } = 64;

        /// <summary>
        /// Default value: 256
        /// </summary>
        public static int MaxEmailLength { get; set; } = 256;

        /// <summary>
        /// Default value: 16
        /// </summary>
        public static int MaxPhoneNumberLength { get; set; } = 16;

        /// <summary>
        ///
        /// </summary>
        public static int MaxPasswordLength { get; set; } = 8;

        /// <summary>
        ///
        /// </summary>
        public const string DefaultInitPassword = "123456";
    }
}