using OpenQA.Selenium;
using ReteGivingEvent.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReteGivingEvent.PAGEOBJECTS
{
    public class ReteGivingHeaderPage
    {
        public IWebDriver driver;

        public ReteGivingHeaderPage()
        {
            driver = BaseTest.driver;
        }

        private By AboutUs = By.CssSelector("#menu-item-1627 > a");
        private By Pricing = By.CssSelector("#menu-item-1628 > a");
        private By EventPlatForm = By.CssSelector("#menu-item-2043 > a");
        private By contactUs = By.CssSelector("#menu-item-1630 > a");
        //private By AboutMessage = By.CssSelector("#about > div > div.h-row-container.gutters-row-lg-2.gutters-row-md-2.gutters-row-2.gutters-row-v-lg-2.gutters-row-v-md-2.gutters-row-v-2.style-176.style-local-1953-c5.position-relative > div > div.h-column.h-column-container.d-flex.h-col-lg-auto.h-col-md-auto.h-col-auto.style-177-outer.style-local-1953-c8-outer > div > div > div.h-global-transition-all.h-heading.style-351.style-local-1953-c9.position-relative.h-element > div > h3");
        //private By PricingMessage = By.CssSelector("#pricing > div > div.h-row-container.gutters-row-lg-2.gutters-row-md-2.gutters-row-2.gutters-row-v-lg-2.gutters-row-v-md-2.gutters-row-v-2.style-195.style-local-1953-c33.position-relative > div > div > div > div > div > div > h3");
        //private By ContactUsMessage = By.CssSelector("div > div > div.h-global-transition-all.h-heading.style-388.style-local-1953-c41.position-relative.h-element > div > h4");        
        public void ClickAboutUs()
        {
            driver.FindElement(AboutUs).Click();
        }

        public void ClickPricing()
        {
            driver.FindElement(Pricing).Click();
        }

        public void ClickEventPlatForm()
        {
            driver.FindElement(EventPlatForm).Click();
        }

        public void ContactUs()
        {
            driver.FindElement(contactUs).Click();
        }

        public bool SuccessfulMessageDisplayed()
        {
            return driver.Url.Contains("#about");
        }

        public bool SuccessDisplayed()
        {
            return driver.Url.Contains("#pricing");
        }

        public bool SusMessageDisplayed()
        {
            return driver.Url.Contains("#contact");
        }
   
    
    
    }
}
