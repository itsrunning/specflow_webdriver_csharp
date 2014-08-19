using System;
using TechTalk.SpecFlow;

namespace SpecFlowSample.pages
{
    [Binding]
    public class VerifyUserCreationSteps
    {
       
        [StepDefinition(@"I navigate to all users page")]
        public void INavigateToAllUsersPage()
        {
            
        }

        [StepDefinition(@"I navigate to create new User")]
        public void INavigateToCreateNewUser()
        {
                      
        }

        [StepDefinition(@"create new user name (.*)")]
        public void CreateNewUserNameDeepak(String name)
        {
                      
        }

        [StepDefinition(@"I see the following users")]
        public void ISeeTheFollowingUsers(Table table)
        {
           
        }
    }
}
