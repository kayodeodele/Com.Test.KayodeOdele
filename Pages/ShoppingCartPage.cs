using OpenQA.Selenium;
using Com.Test.KayodeOdele.Drivers;

namespace Com.Test.KayodeOdele.Pages
{
    public class ShoppingCartPage
    {
        public string Title()
        {
            return Driver.driver.Title;
        }

        public IWebElement ProceedToCheckOutLink()
        {
            return Driver.driver.FindElement(By.CssSelector("div#center_column  a[title='Proceed to checkout']"));
        }

        public IWebElement AddressProceedToCheckoutLink()
        {
            return Driver.driver.FindElement(By.CssSelector("button[name='processAddress']"));
        }

        public IWebElement TOSCheckBox()
        {
            return Driver.driver.FindElement(By.Id("cgv"));
        }

        public IWebElement ShippingProceedToCheckoutLink()
        {
            return Driver.driver.FindElement(By.CssSelector(".standard-checkout span"));
        }

        public IWebElement PayByBankWire()
        {
            return Driver.driver.FindElement(By.CssSelector("[title='Pay by bank wire']"));
        }
    }
}
