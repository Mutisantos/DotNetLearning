using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _002aspnet.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _002aspnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Host = CreateHostBuilder(args).Build();
            using(var scope = Host.Services.CreateScope()){
                var services = scope.ServiceProvider;
                try
                {
                    var escuelaContext = services.GetRequiredService<EscuelaContext>();
                    escuelaContext.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "exception while configuring Database Context");
                }
            }
            Host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
