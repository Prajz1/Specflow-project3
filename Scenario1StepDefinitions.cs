using OpenQA.Selenium;
using SpecFlowProject3.Drivers;
using SpecFlowProject3.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class Scenario1StepDefinitions : Class1
    {
        //Class1 basedriver;

        [Given(@"Navigate to url")]
        public void GivenNavigateToUrl()
        {
            launchurl();
           
        }

        [When(@"clicked to login page")]
        public void WhenClickedToLoginPage()
        {
            // throw new PendingStepExecution();
            SignUp S = new SignUp(driver);
            S.loginbutton.Click();
        }

        [When(@"click to sign up page")]
        public void WhenClickToSignUpPage()
        {
            SignUp L = new SignUp(driver);
            L.SignUpbutton.Click();
        }

        [When(@"I enter the following field")]
        public void WhenIEnterTheFollowingField(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"sign up page will be displayed")]
        public void ThenSignUpPageWillBeDisplayed()
        {
            throw new PendingStepException();
        }

    }
}
