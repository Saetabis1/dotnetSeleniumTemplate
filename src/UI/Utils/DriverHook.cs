namespace src.Utils
{
    using System;
    using System.IO;
    using System.Reflection;
    using Microsoft.Extensions.Configuration;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Remote;

    public class DriverHook
    {
        public IWebDriver Driver;

        public void DriverHookTearDown()
        {
            Driver.Quit();
        }

        public DriverHook()
        {
       // Can be Local or Remote
            var server = Configuration.Get["server"];
            
            // Can be Chrome or Firefox
            var browser = Configuration.Get["browser"];

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
                    var seleniumHubUrl = Configuration.Get["seleniumHubUrl"];
                    switch (browser)
                    { 
                        case "Chrome":
                            var chromeOptions = new ChromeOptions();

                            chromeOptions.AddArgument("start-maximized");

                            var cap = chromeOptions.ToCapabilities();

                            Driver = new RemoteWebDriver(new Uri(seleniumHubUrl), cap); 
                        break;
                        case "Firefox":

                        break;
                    }
                    break;
                default:
                    throw new WrongParameterException($"Parameter Server is wrong. It has to be 'Local' or 'remote' and it was {server}");
            }
        }       
    }
}