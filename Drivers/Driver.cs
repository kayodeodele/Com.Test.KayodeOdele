using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.Test.KayodeOdele.Drivers
{
    public static class Driver
    {
        public static IWebDriver driver { get; private set; }

        public static void Initialise()
        {
            driver = new ChromeDriver();
        }

        public static void Close()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }   
    }
    
}
