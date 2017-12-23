namespace src.Webapi.TwitterControllers
{
    public class StatusController
    {
        private static string baseUrl = Configuration.Get["TwitterBaseUrl"];
        private static string resource = Configuration.Get["TwitterStatusResource"];

        public void update(Parameters parameters)
        {
            
        }
    }
}