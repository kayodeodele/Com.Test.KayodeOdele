using Com.Test.KayodeOdele.Drivers;
using OpenQA.Selenium;

namespace Com.Test.KayodeOdele.Pages
{
    public class LoginPage
    {

        public IWebElement Signin()
        {
            return Driver.driver.FindElement(By.LinkText("Sign in"));
        }
        public IWebElement Email()
        {
            return Driver.driver.FindElement(By.Id("email"));
        }

        public IWebElement Password()
        {
            return Driver.driver.FindElement(By.Id("passwd"));
        }

        public IWebElement SubmitLoginButton()
        {
            return Driver.driver.FindElement(By.Id("SubmitLogin"));
        }

    }
}
