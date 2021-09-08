using OpenQA.Selenium;
using ReteGivingEvent.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReteGivingEvent.PAGEOBJECTS
{
    class BackGroundImagePage
    {
        IWebDriver driver;

        public BackGroundImagePage()
        {
            driver = BaseTest.driver;
        }

        private By successImage = By.CssSelector("#hero");

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool successImageDisplayed()
        {
            return driver.FindElement(successImage).Displayed;
        }


    }
}
