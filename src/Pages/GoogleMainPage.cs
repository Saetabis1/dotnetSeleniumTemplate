namespace src.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using src.Elements;

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
                Assert.IsTrue(googleMainElements.GoogleIcon.Displayed);
            }
            catch(AssertionException)
            {
                throw new WrongPageException("Should be on Google main page but it is on: " + Driver.Url);
            }
        }
    }
}