using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace WebLab
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Класс для запуска веб-сайта
                    webBuilder.UseStartup<Startup>();

                    // Используем для отображения папку с содержимым нашего сайта
                    webBuilder.UseWebRoot("Content");
                });
    }
}
