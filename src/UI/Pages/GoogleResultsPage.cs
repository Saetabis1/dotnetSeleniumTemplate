namespace src.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using src.Elements;

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
                Assert.IsTrue(resultsPageElements.UpperSearchTextbox.Displayed);
            }
            catch(AssertionException)
            {
                throw new WrongPageException("Should be on Google Results page but it is on: " + Driver.Url);
            }
        }
    }
}
