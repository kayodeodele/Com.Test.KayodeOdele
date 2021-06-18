using OpenQA.Selenium;
using Com.Test.KayodeOdele.Drivers;

namespace Com.Test.KayodeOdele.Pages
{
    public class OrderConfirmationPage
    {
        public string Title()
        {
            return Driver.driver.Title;
        }

        public IWebElement ViewMyAccount()
        {
            return Driver.driver.FindElement(By.CssSelector("a[title='View my customer account'] > span"));
        }

    }
}
