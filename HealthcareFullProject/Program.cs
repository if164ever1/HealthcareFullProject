using Healthcare;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace HealthcareFullProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateUserHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateUserHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
