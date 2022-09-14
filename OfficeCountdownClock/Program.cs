using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace OfficeCountdownClock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.AddHealthChecks().AddCheck<CustomHealthCheck>("custom_hc");
                });
    }
}
