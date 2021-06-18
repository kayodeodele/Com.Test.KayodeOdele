using Com.Test.KayodeOdele.Drivers;
using Com.Test.KayodeOdele.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Threading;

namespace Com.Test.KayodeOdele.Steps
{
    [Binding]
    public class StoreSteps
    {
        LoginPage _loginpage = new LoginPage();
        OrderPage _orderPage = new OrderPage();
        ShoppingCartPage _shoppingCartPage = new ShoppingCartPage();
        ConfirmOrderPage _confirmOrderPage = new ConfirmOrderPage();
        OrderConfirmationPage _orderConfirmationPage = new OrderConfirmationPage();
       
        [Given(@"I have navigated to the store website")]
        public void GivenIHaveNavigatedToTheStoreWebsite()
        {
            
            Driver.driver.Navigate().GoToUrl("http://automationpractice.com");
        }

        [Given(@"I click Sigh in")]
        public void GivenIClickSighIn()
        {
            _loginpage.Signin().Click();
        }


        [Given(@"I enter my email (.*) and password (.*)")]
        [When(@"I enter my email (.*) and password (.*)")]
        public void GivenIEnterMyEmail_AndPassword_(string email, string password)
        {
            _loginpage.Email().Clear();
            _loginpage.Email().SendKeys(email);
            _loginpage.Password().Clear();
            _loginpage.Password().SendKeys(password);
        }

        [Given(@"I Click Sign in button")]
        public void GivenIClickSignInButton()
        {
            _loginpage.SubmitLoginButton().Click();
        }
       

        [Then(@"I should land on the (.*) page")]
        public void ThenIShouldLandOnThe_Page(string page)
        {
            if (page == "Order")
            {
                var title = "My account - My Store";
                Assert.AreEqual(title, _orderPage.Title());
            }
            else if (page == "Shopping-Cart Summary")
            {
                var title = "Order - My Store";
                Assert.AreEqual(title, _shoppingCartPage.Title());
            }

            else if (page == "Order Summary")
            {
                var title = "My Store";
                Assert.AreEqual(title, _shoppingCartPage.Title());
            }

            else if (page == "Order Confirmation - My Store")
            {
                var title = "Order Confirmation";
                Assert.AreEqual(title, _shoppingCartPage.Title());
            }

        }

        [When(@"I select TShirt link")]
        public void WhenISelectTShirtLink()
        {
            _orderPage.TShirtLink().Click();
        }

        [When(@"I hover over the available product")]
        public void WhenIHoverOverTheAvailableProduct()
        {
            _orderPage.HoverOverProduct();
        }

        [When(@"I select Add to Cart")]
        public void WhenISelectAddToCart()
        {
            _orderPage.AddToCartLink().Click();
        }

        [When(@"I select Proceed to checkout")]
        public void WhenISelectProceedToCheckout()
        {
            Thread.Sleep(3000);
            _orderPage.ProceedToCheckOutLink().Click();
        }

        [When(@"I select Proceed to checkout on Shopping cart")]
        public void WhenISelectProceedToCheckoutOnShoppingCart()
        {
            _shoppingCartPage.ProceedToCheckOutLink().Click();
        }

        [When(@"I select Proceed to checkout after Address check")]
        public void WhenISelectProceedToCheckoutAfterAddressCheck()
        {
            _shoppingCartPage.AddressProceedToCheckoutLink().Click();
        }

        [When(@"I tick the terms of service for shipping")]
        public void WhenITickTheTermsOfServiceForShipping()
        {
            _shoppingCartPage.TOSCheckBox().Click();
        }

        [When(@"I select Proceed to checkout on the Shipping page")]
        public void WhenISelectProceedToCheckoutOnTheShippingPage()
        {
            _shoppingCartPage.ShippingProceedToCheckoutLink().Click();
        }

        [When(@"I select pay by wire")]
        public void WhenISelectPayByWire()
        {
            _shoppingCartPage.PayByBankWire().Click();
        }

        [When(@"I confirm my order")]
        public void WhenIConfirmMyOrder()
        {
            _confirmOrderPage.ConfirmOrderLink().Click();
        }

        [When(@"I select to view my account")]
        public void WhenISelectToViewMyAccount()
        {
            _orderConfirmationPage.ViewMyAccount().Click();
        }

        [When(@"I select Order history and details")]
        public void WhenISelectOrderHistoryAndDetails()
        {
            _orderPage.OrderHistoryLink().Click();
        }

        [Then(@"I should see my orders listed")]
        public void ThenIShouldSeeMyOrdersListed()
        {
            Assert.IsTrue(_orderPage.TableRows().Count > 0);
        }

        [When(@"I select my personal information")]
        public void WhenISelectMyPersonalInformation()
        {
            _orderPage.MyPersonalInformationLink().Click();
        }

        [When(@"I update my firstname to (.*)")]
        public void WhenIUpdateMyFirstnameTo_(string updateFirstName)
        {
            _orderPage.FirstName().Clear();
            _orderPage.FirstName().SendKeys(updateFirstName);
        }

        [When(@"I enter my password (.*)")]
        public void WhenIEnterMyPassword_(string password)
        {
            _orderPage.CurrentPassword().Clear();
            _orderPage.CurrentPassword().SendKeys(password);
        }

        [When(@"I click Save")]
        public void WhenIClickSave()
        {
            _orderPage.Save().Click();
        }

        [Then(@"I should get an alert that the update is successful")]
        public void ThenIShouldGetAnAlertThatTheUpdateIsSuccessful()
        {
            Assert.IsTrue(_orderPage.SuccessAlert().Displayed);
        }
    }
}
