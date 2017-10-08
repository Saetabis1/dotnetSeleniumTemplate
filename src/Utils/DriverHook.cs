namespace src.Utils
{
    using System.IO;
    using System.Reflection;
    using Microsoft.Extensions.Configuration;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;

    public class DriverHook
    {
        public IWebDriver Driver;

        [TearDown]
        public void DriverHookTearDown()
        {
            Driver.Quit();
        }

        [SetUp]
        public void DriverHookSetup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json");

            var configuration = builder.Build();

            // Can be Local or Remote
            var server = configuration["server"];
            
            // Can be Chrome or Firefox
            var browser = configuration["browser"];

            switch (server)
            {
                case "Local":
                    switch (browser)
                    {
                        case "Chrome":
                            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                            break;
                        case "Firefox":
                            Driver = new FirefoxDriver();
                            break;
                        default:
                            throw new WrongParameterException($"Parameter Browser is wrong. It has to be 'Chrome' or 'Firefox' and it was {browser}");
                    }
                    break;
                case "Remote":
                    switch (browser)
                    {
                         case "Chrome":
                            
                        break;
                    }
                    break;
                default:
                    throw new WrongParameterException($"Parameter Server is wrong. It has to be 'Local' or 'remote' and it was {server}");
            }

        }       
    }
}