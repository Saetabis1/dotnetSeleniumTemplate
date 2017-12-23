
namespace src.Webapi.TwitterControllers
{
    using System.Linq;
    using RA;
    public class StatusController
    {
        private static string baseUrl = Configuration.Get["TwitterBaseUrl"];
        private static string resource = Configuration.Get["TwitterStatusResource"];

        public void update(Parameters parameters)
        {
            var requestGiven = new RestAssured().Given();
            requestGiven.Name("Tweet")
                        .Header("Content-Type", "application/json")
                        .Header("Accept-Encoding", "gzip,deflate");
            foreach(var item in parameters)
            {
                requestGiven.Param(item.Key,item.Value.ToString());
            }
                
            requestGiven
                .When()
                    .Debug()
                    .Post(baseUrl + resource + @"\update.json")
                .Then();
                    


        }
    }
}