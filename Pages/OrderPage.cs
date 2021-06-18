using OpenQA.Selenium;
using Com.Test.KayodeOdele.Drivers;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;


namespace Com.Test.KayodeOdele.Pages
{
    public class OrderPage
    {
        public string Title()
        {
            return Driver.driver.Title;
        }

        public IWebElement TShirtLink()
        {
            return Driver.driver.FindElement(By.CssSelector("li:nth-of-type(3) > a[title='T-shirts']"));
        }

        public void HoverOverProduct()
        {
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(Driver.driver.FindElement(By.CssSelector("[alt='Faded Short Sleeve T-shirts']"))).Build().Perform();
        }

        public IWebElement AddToCartLink()
        {
            return Driver.driver.FindElement(By.LinkText("Add to cart"));
        }

        public IWebElement ProceedToCheckOutLink()
        {
            return Driver.driver.FindElement(By.CssSelector("[title='Proceed to checkout'] span"));
        }

        public IWebElement OrderHistoryLink()
        {
            return Driver.driver.FindElement(By.CssSelector("a[title='Orders'] > span"));
        }

        public IWebElement OrderReferenceNo()
        {
            return Driver.driver.FindElement(By.CssSelector(".first_item  .color-myaccount"));
        }

        public IWebElement OrderDate()
        {
            return Driver.driver.FindElement(By.CssSelector(".first_item > .bold.history_date"));
        }

        public IWebElement OrderPrice()
        {
            return Driver.driver.FindElement(By.CssSelector(".first_item > .history_price"));
        }

        public IWebElement MyPersonalInformationLink()
        {
            return Driver.driver.FindElement(By.CssSelector("a[title='Information'] > span"));
        }

        public IWebElement FirstName()
        {
            return Driver.driver.FindElement(By.Id("firstname"));
        }

        public IWebElement CurrentPassword()
        {
            return Driver.driver.FindElement(By.Id("old_passwd"));
        }

        public IWebElement Save()
        {
            return Driver.driver.FindElement(By.Name("submitIdentity"));
        }

        public IWebElement SuccessAlert()
        {
            return Driver.driver.FindElement(By.CssSelector(".alert-success"));
        }

        public IList<IWebElement> TableRows()
        {
            var table = Driver.driver.FindElement(By.Id("order-list"));

            var tableRows = table.FindElements(By.TagName("tr")).ToList();

            return tableRows;
        }
    }
}
