namespace src.Elements
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using src.Elements.Interfaces;

    public class MainPageElements : IMainPageElements 
    {
        private IWebDriver Driver;

        public MainPageElements(IWebDriver driver)
        {
            Driver = driver;            
        }
        public IWebElement GoogleIcon
        {
            get { return Driver.FindElement(By.Id("hplogo"));}
        }
        public IWebElement SearchBox
        {
            get {return Driver.FindElement(By.Id("lst-ib"));}
        }
    }
}