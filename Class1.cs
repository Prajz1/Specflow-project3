using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.Drivers
{
    public class Class1
    {
        public IWebDriver driver;


        public void launchurl()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.espn.in/cricket/");
            Environment.Exit(0);
            

        }

    }
}
