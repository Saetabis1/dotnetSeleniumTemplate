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
            Assert.IsTrue(resultsPageElements.GoogleIcon.Displayed);
        }
    }
}
