﻿using Laison.Lapis.Host.Shared;

namespace Laison.Lapis.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostEx.Run<Startup>(args);
        }
    }
}