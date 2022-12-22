using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using SeleniumExtras.PageObjects;
using SpecFlowProject3.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.Pages
{
    public class SignUp : Class1
    {



        public SignUp(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "button-alt med")]

        public IWebElement loginbutton { get; set; }



        [FindsBy(How = How.CssSelector, Using = " #BtnCreateAccount")]

        public IWebElement SignUpbutton { get; set; }


        public IWebElement Loginbutton()
        {
            return loginbutton;
        }

        public IWebElement signUpbutton()
        {
            return SignUpbutton;
        }
    }
    
}
