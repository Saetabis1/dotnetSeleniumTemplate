namespace src.Pages
{
    using OpenQA.Selenium;
    using src.Elements;
    using Xunit;
    using Xunit.Sdk;

    public class GoogleResultsPage
    {
        private IWebDriver Driver;

        private ResultsPageElements resultsPageElements;

        public GoogleResultsPage(IWebDriver webDriver)
        {
            Driver = webDriver;

            resultsPageElements = new ResultsPageElements(Driver);
        }

        public void StandingOnPage ()
        {
            try
            {
                Assert.True(resultsPageElements.UpperSearchTextbox.Displayed);
            }
            catch(TrueException)
            {
                throw new WrongPageException("Should be on Google Results page but it is on: " + Driver.Url);
            }
        }
    }
}
