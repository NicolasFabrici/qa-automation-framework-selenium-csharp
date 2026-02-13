using Microsoft.Extensions.Configuration;
using System.IO;

namespace QAFramework.Utilities
{
    public class ConfigReader
    {
        private static IConfigurationRoot configuration;

        static ConfigReader()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Config/appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
        }

        public static string BaseUrl => configuration["BaseUrl"];
        public static string Browser => configuration["Browser"];
        public static int Timeout => int.Parse(configuration["Timeout"]);
    }
}