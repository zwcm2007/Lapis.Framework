namespace Laison.Lapis.PermissionManagement.Domain
{
    public static class PermissionManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = "PermissionManagement";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "PermissionManagement";
    }
}
