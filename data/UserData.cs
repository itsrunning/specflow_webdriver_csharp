using System;
using TechTalk.SpecFlow;

namespace SpecFlowSample.data
{
    [Binding]
    public class UserData
    {
        [StepDefinition(@"I have a user called (.*)")]
        public void IHaveAUserCalled(String name)
        {
            

        }
    }
}
