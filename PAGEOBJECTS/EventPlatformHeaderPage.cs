using OpenQA.Selenium;
using ReteGivingEvent.HOOK;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReteGivingEvent.PAGEOBJECTS
{
    class EventPlatformHeaderPage
    {
        public IWebDriver driver;




        public EventPlatformHeaderPage()
        {
            driver = BaseTest.driver;
        }

    }
}
