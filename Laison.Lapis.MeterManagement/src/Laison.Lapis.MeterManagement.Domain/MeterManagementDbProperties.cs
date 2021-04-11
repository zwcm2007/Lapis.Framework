namespace Laison.Lapis.MeterManagement.Domain
{
    public static class MeterManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = "MeterManagement";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "MeterManagement";
    }
}
