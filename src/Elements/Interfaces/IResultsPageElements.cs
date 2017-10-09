namespace src.Elements.Interfaces
{
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public interface IResultsPageElements 
    {
        IWebElement GoogleIcon {get;}
        IList<IWebElement> Results {get;}

        string ResultsCount {get;}
    }
}