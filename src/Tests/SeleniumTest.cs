namespace src.Tests
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using System.IO;
    using System.Reflection;
    using src.Utils;
    using src.Pages;

    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class SeleniumTest : DriverHook
    {
        // Simple Test to show how we use Page Objects Models With Selenium        
        [Test]
        [Category("Chapter1")]
        public void GoogleMainSearchTest()
        {
            var googleMainPage = new GoogleMainPage(Driver);

            googleMainPage.Navigate();

            googleMainPage.StandingOnPage();

            googleMainPage.Search("Selenium");

            var googleResultsPage = new GoogleResultsPage(Driver);

            googleResultsPage.StandingOnPage();
        }
    }
}
