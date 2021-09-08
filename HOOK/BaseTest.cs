using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ReteGivingEvent.HOOK
    

{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void Beforescenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Maximize();
          
        }

        [AfterScenario]
        public static void Afterscenario()
        {
            driver.Close();
            driver.Quit();
        }






    }
}
