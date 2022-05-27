using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Soccer.Web
{
    public class ProgramBase
    {

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}