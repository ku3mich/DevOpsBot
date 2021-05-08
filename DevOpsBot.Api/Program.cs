using DevOpsBot.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NLog.Web;

try
{
    Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
    .UseNLog()
    .Build()
    .Run();
}
finally
{
    NLog.LogManager.Shutdown();
}

