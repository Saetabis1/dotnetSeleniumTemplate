namespace src.Elements
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class GoogleMainElements
    {
        private IWebDriver Driver;
        public const string searchTextBox_Id = "lst-ib";

        public GoogleMainElements(IWebDriver driver)
        {
            Driver = driver;            
        }

        public IWebElement SearchBox
        {
            get { return Driver.FindElement(By.Id(searchTextBox_Id));}
        }
    }
}