using NUnit.Framework;
using OpenQA.Selenium;
using ReteGivingEvent.HOOK;
using ReteGivingEvent.PAGEOBJECTS;
using TechTalk.SpecFlow;

namespace ReteGivingEvent.STEPDEFINITIONS
{
    [Binding]
    public class CookieBannerSteps
    {

        public IWebDriver driver = BaseTest.driver;
        CookieBannerPage _cookieBannerPage = new CookieBannerPage();

        [Given(@"User navigates to  https://retegiving\.com/")]
        public void GivenUserNavigatesToHttpsRetegiving_Com()
        {
            driver.Navigate().GoToUrl(@"https://retegiving.com/");
        }


        [When(@"User  clicks on cookie settings")]
        public void WhenUserClicksOnCookieSettings()
        {
            _cookieBannerPage.ClickCookieSettings();
        }

        [When(@"User clicks on save and accept")]
        public void WhenUserClicksOnSaveAndAccept()
        {
            _cookieBannerPage.clickAcceptandSaveButton();
        }

        [When(@"User clicks on accept button")]
        public void WhenUserClicksOnAcceptButton()
        {
            _cookieBannerPage.clickAcceptandSaveButton();
        }

        [Then(@"Company is GDPR compliance")]
        public void ThenCompanyIsGDPRCompliance()
        {
            Assert.IsTrue(_cookieBannerPage.IsPageDisplayed());
        }
    }
}
