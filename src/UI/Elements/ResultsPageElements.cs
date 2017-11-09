namespace src.Elements
{
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using src.Elements.Interfaces;

    public class ResultsPageElements : IResultsPageElements 
    {
        private IWebDriver Driver;

        public ResultsPageElements(IWebDriver driver)
        {
            Driver = driver;            
        }

        public string ResultsCount
        {
            get { return Driver.FindElement(By.Id("")).Text;}
        }

        public IWebElement UpperSearchTextbox
        {
            get { return Driver.FindElement(By.Id("sfdiv"));}
        }

        public IList<IWebElement> Results
        {
            get { return Driver.FindElements(By.Id(""));}
        }
    }
}