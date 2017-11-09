namespace src.Tests
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using System.IO;
    using System.Reflection;
    using src.Pages;
    using src.Models;
    using Newtonsoft.Json;

    [TestFixture]
    public class JsonConverterTest 
    {
        // This test is to show how we use Data in the framework totally decoupled from code
        [TestCase("NormalUser")]
        [TestCase("AdminUser")]
        public void ConvertJsonToObjectTest(string userFileName)
        {
            var jsonString = File.ReadAllText(Directory.GetCurrentDirectory() + $"/src/Data/UserDataSet/{userFileName}.json");

            var user = JsonConvert.DeserializeObject<User>(jsonString);

            Assert.That(user.Username.Equals(userFileName));
        }
    }
}
