namespace src.Pages
{
    using OpenQA.Selenium;
    using src.Elements;

    public class GoogleMainPage
    {
        private IWebDriver Driver;

        private GoogleMainElements googleMainElements;

        public GoogleMainPage(IWebDriver webDriver)
        {
            Driver = webDriver;

            googleMainElements = new GoogleMainElements(Driver);
        }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl(@"https://www.google.com");
        }

        public void Search(string searchInput)
        {
            googleMainElements.SearchBox.SendKeys(searchInput + Keys.Enter);
        }
    }
}
