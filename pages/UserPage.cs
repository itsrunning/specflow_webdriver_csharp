using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowSample.pages
{
    [Binding]
    public class UserPage : BasePage
    {
       
        [StepDefinition(@"I navigate to all users page")]
        public void INavigateToAllUsersPage()
        {
            Driver.Navigate().GoToUrl("http://localhost:8080/users/all");
        }

        [StepDefinition(@"I navigate to create new User")]
        public void INavigateToCreateNewUser()
        {
            Driver.FindElementByLinkText("Create New User").Click();
        }

        [StepDefinition(@"create new user name (.*)")]
        public void CreateNewUserNameDeepak(String name)
        {
            Driver.FindElementByCssSelector("[type=text]").SendKeys(name);
            Driver.FindElementByCssSelector("[type=submit]").Click();
                      
        }

        [StepDefinition(@"I see the following users")]
        public void ISeeTheFollowingUsers(Table table)
        {
            var rows = table.Rows.ToList();
            foreach (var row in rows)
            {
                var rowIndex = (rows.IndexOf(row) +1);
                Assert.AreEqual(Driver.FindElementByCssSelector("tr:nth-of-type("+ rowIndex +") .name").Text,row["name"]);
            }
        }
    }
}
