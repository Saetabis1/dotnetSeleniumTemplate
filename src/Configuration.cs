namespace src
{
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public static class Configuration
    {
        public static IConfigurationRoot Get = SetConfig();

        private static IConfigurationRoot SetConfig()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json");

            return builder.Build();
        }
    }       
}
