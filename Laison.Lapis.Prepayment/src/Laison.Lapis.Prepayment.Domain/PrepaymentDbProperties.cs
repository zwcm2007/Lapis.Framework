namespace Laison.Lapis.Prepayment.Domain
{
    public static class PrepaymentDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Prepayment";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Prepayment";
    }
}
