using OpenQA.Selenium.Firefox;
using SpecFlowSample.data.models;
using SpecFlowSample.pages;
using TechTalk.SpecFlow;

namespace SpecFlowSample
{
    [Binding]
    class Hooks : BasePage
    {
        [BeforeTestRun]
        public static void StartSelenium()
        {
            Driver  = new FirefoxDriver();
        }

        [BeforeScenario]
        public static void ClearDb()
        {
            User.DeleteAll();            
        }

        [AfterTestRun]
        public static void Close()
        {
            Driver.Quit();
        }

    }
}
