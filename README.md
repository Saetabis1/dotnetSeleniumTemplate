# dotnetSeleniumTemplate
A ready to roll template to start testing systems

# First Steps
## Install net core
    # https://www.microsoft.com/net/learn/get-started/windows
    # https://www.microsoft.com/net/learn/get-started/linuxubuntu
    # https://www.microsoft.com/net/learn/get-started/macos 
## Install Visual Studio Code (Or use IDE of preference)
    # https://code.visualstudio.com/
## Install Docker
    # https://www.docker.com/get-docker
## Install Docker Compose
    # https://docs.docker.com/compose/install/
## Clone dotnetSeleniumTemplate
    # 'git clone https://github.com/Saetabis1/dotnetSeleniumTemplate.git' where you want to place repository
## Start Docker
    # Go to Docker/ folder in dotnetSeleniumTemplate repository in any terminal 
    # Type 'sudo docker-compose up -d'
## Run tests
    # Stand in dotnetSeleniumTemplate folder in any terminal
    # Type 'dotnet test' and hit enter
    # If you want to run only one you can use dote 'dotnet test --filter "TestCategory = yourCategory"'

# Working with Data
## Creation of model in a class
    ```
    namespace src.Models
    {
        public class User : IModel
        {
            public string Username {get; set;}

            public string Password {get; set;}
        }
    }
    ```

## Creation of json with data
    ```
    {
        "Username": "AdminUser", 
        "Password": "Admin"
    }
    ```

## Convert json to object to use it in tests
    ```
    [TestCase("AdminUser")]
    public void ConvertJsonToObjectTest(string userFileName)
    {
        var jsonString = File.ReadAllText(Directory.GetCurrentDirectory() + $"/src/Data/UserDataSet/{userFileName}.json");

        var user = JsonConvert.DeserializeObject<User>(jsonString);

        Assert.That(user.Username.Equals(userFileName));
    }
    ```

# Soon
    # Support Webservices Tests
    # Support Backend connections
        ## SQL
        ## NOSQL
        ## Solr / ELK
