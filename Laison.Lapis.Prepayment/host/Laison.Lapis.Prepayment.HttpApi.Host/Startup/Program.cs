using Laison.Lapis.Shared.Host;

namespace Laison.Lapis.Prepayment
{
    public class Program
    {
        public static int Main(string[] args)
        {
            return HostEx.Run<Startup>(args);
        }
    }
}