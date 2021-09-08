using OpenQA.Selenium;
using ReteGivingEvent.HOOK;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReteGivingEvent.PAGEOBJECTS
{
    class EventPlatformButtonPage
    {
        public IWebDriver driver;




        public EventPlatformButtonPage()
        {
            driver = BaseTest.driver;
        }
    }
}
