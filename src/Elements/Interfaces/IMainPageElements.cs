namespace src.Elements.Interfaces
{
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public interface IMainPageElements
    {
        IWebElement GoogleIcon {get;}
        IWebElement SearchBox {get;}
    }
}