namespace src.Tests
{
    using NUnit.Framework;
    using System.IO;
    using System.Reflection;
    using Newtonsoft.Json;
    using src.Models;

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
