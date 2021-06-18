using TechTalk.SpecFlow;
using Com.Test.KayodeOdele.Drivers;

namespace Com.Test.KayodeOdele.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Driver.Initialise();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Close();
        }
    }
}
