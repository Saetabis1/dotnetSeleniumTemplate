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
    public class MainSearchTests : DriverHook
    {
        [Test]
        [Category("Chapter1")]
        public void MainSearchTest()
        {
            var googleMainPage = new GoogleMainPage(Driver);

            googleMainPage.Navigate();

            googleMainPage.Search("Selenium");
        }

        [Test]
        [Category("Chapter2")]
        public void MainSearchTest2()
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
