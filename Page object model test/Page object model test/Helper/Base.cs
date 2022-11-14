using Page_object_model_test.Driver;

namespace Page_object_model_test.Helper
{
    public class Base
    {
        [SetUp]
        public static void BeforeScenario()
        {
            WebDriver.Initialization();
        }

        [TearDown]
        public static void AfterScenario()
        {
            WebDriver.CleanUp();
        }
    }
}
