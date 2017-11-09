namespace src.Utils
{
    using System;
    using System.IO;
    using System.Reflection;
    using Microsoft.Extensions.Configuration;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Remote;

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

            var binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            
            switch (server)
            {
                case "Local":
                    switch (browser)
                    {
                        case "Chrome":
                            Driver = new ChromeDriver(binPath);
                            break;
                        case "Firefox":
                            var service = FirefoxDriverService.CreateDefaultService(binPath);
                            service.FirefoxBinaryPath = @"C:\Users\mmarcatilli\AppData\Local\Mozilla Firefox\firefox.exe";
                            Driver = new FirefoxDriver(service);
                            break;
                        default:
                            throw new WrongParameterException($"Parameter Browser is wrong. It has to be 'Chrome' or 'Firefox' and it was {browser}");
                    }
                    break;
                case "Remote":
                    switch (browser)
                    {
                         case "Chrome":
                            var chromeOptions = new ChromeOptions();

                            chromeOptions.AddArgument("start-maximized");

                            var cap = chromeOptions.ToCapabilities();

                            Driver = new RemoteWebDriver(new Uri("http://localhost:32768/wd/hub"), cap); 
                        break;
                    }
                    break;
                default:
                    throw new WrongParameterException($"Parameter Server is wrong. It has to be 'Local' or 'remote' and it was {server}");
            }
        }       
    }
}