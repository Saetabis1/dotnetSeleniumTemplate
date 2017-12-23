namespace src.Tests
{
    using System.IO;
    using System.Reflection;
    using Newtonsoft.Json;
    using src.Models;
    using Xunit;

    public class JsonConverterTest 
    {
        // This test is to show how we use Data in the framework totally decoupled from code
        [Theory]
        [InlineData("AdminUser")]
        [InlineData("NormalUser")]
        public void ConvertJsonToObjectTest(string userFileName)
        {
            var jsonString = File.ReadAllText(Directory.GetCurrentDirectory() + $"/src/Data/UserDataSet/{userFileName}.json");

            var user = JsonConvert.DeserializeObject<User>(jsonString);

            Assert.Equal(user.Username,userFileName);
        }
    }
}
