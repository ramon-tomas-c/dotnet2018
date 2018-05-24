using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApi.Extensions;
using WebApi.Infrastructure;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args)
                .MigrateDbContext<BeersContext>((context, services) =>
                {
                    var logger = services.GetService<ILogger<BeersContextSeed>>();

                    new BeersContextSeed()
                        .SeedAsync(context, logger)
                        .Wait();
                })
                .Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()                
                .Build();
    }
}
