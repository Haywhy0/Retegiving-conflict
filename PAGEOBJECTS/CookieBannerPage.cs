using OpenQA.Selenium;
using ReteGivingEvent.HOOK;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReteGivingEvent.PAGEOBJECTS
{
    class CookieBannerPage
    {

        private By CookieSettings = By.CssSelector("#cookie-law-info-bar > span > div > div.cli-bar-btn_container > a.medium.cli-plugin-button.cli-plugin-main-button.cli_settings_button");
        private By AcceptandSaveButton = By.CssSelector("#wt-cli-privacy-save-btn");
        private By LandingPage = By.CssSelector("div.h-column.h-column-container.d-flex.h-col-none.style-4-outer.style-local-7-h4-outer > div > div > div > a > span");
        
        public IWebDriver driver;
        

        public CookieBannerPage()
        {
            driver = BaseTest.driver;
        }

        public void ClickCookieSettings()
        {
            driver.FindElement(CookieSettings).Click();
        }

        public void clickAcceptandSaveButton()
        {
            driver.FindElement(AcceptandSaveButton).Click();
        }

        public bool IsPageDisplayed()
        {
            return driver.FindElement(LandingPage).Displayed;
        }
    }
}
