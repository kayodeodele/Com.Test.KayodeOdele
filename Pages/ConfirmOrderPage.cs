using OpenQA.Selenium;
using Com.Test.KayodeOdele.Drivers;

namespace Com.Test.KayodeOdele.Pages
{
    public class ConfirmOrderPage
    {
        public string Title()
        {
            return Driver.driver.Title;
        }

        public IWebElement ConfirmOrderLink()
        {
            return Driver.driver.FindElement(By.CssSelector("#cart_navigation span"));
        }
    }
}
