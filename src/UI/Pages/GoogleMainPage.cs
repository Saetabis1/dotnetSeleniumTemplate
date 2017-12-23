namespace src.Pages
{
    using OpenQA.Selenium;
    using src.Elements;
    using Xunit;
    using Xunit.Sdk;

    public class GoogleMainPage
    {
        private IWebDriver Driver;

        private MainPageElements googleMainElements;
        
        public GoogleMainPage(IWebDriver webDriver)
        {
            Driver = webDriver;

            googleMainElements = new MainPageElements(Driver);
        }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl(@"https://www.google.com");
        }

        public void Search(string searchInput)
        {
            googleMainElements.SearchBox.SendKeys(searchInput + Keys.Enter);
        }

        public void StandingOnPage ()
        {
            try
            {
                Assert.True(googleMainElements.GoogleIcon.Displayed);
            }
            catch(TrueException)
            {
                throw new WrongPageException("Should be on Google main page but it is on: " + Driver.Url);
            }
        }
    }
}