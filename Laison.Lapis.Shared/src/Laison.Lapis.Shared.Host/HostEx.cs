using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;

namespace Laison.Lapis.Host.Shared
{
    public class HostEx
    {
        public static void Run<TStartup>(string[] args) where TStartup : class
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
                //.WriteTo.File("Logs/logs.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Logger(lg => lg.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Debug)
                   .WriteTo.File("Logs/Debug/logs.txt", rollingInterval: RollingInterval.Day))
                .WriteTo.Logger(lg => lg.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Information)
                   .WriteTo.File("Logs/Info/logs.txt", rollingInterval: RollingInterval.Day))
                .WriteTo.Logger(lg => lg.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Error)
                   .WriteTo.File("Logs/Error/logs.txt", rollingInterval: RollingInterval.Day))
                .CreateLogger();

            Log.Information("Starting web host.");

            try
            {
                CreateHostBuilder<TStartup>(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Host terminated unexpectedly!");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static IHostBuilder CreateHostBuilder<TStartup>(string[] args) 
            where TStartup : class
        {
            return Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<TStartup>();
                 })
                 .UseAutofac()
                 .UseSerilog();
        }
    }
}