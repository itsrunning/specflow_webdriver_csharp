using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowSample
{
    [Binding]
    class Hooks
    {
        private static FirefoxDriver driver;
        [BeforeTestRun]
        public static void StartSelenium()
        {
            driver  = new FirefoxDriver();
        }

        [AfterTestRun]
        public static void Close()
        {
            driver.Quit();
        }

    }
}
