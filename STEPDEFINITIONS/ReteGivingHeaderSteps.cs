using NUnit.Framework;
using ReteGivingEvent.PAGEOBJECTS;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ReteGivingEvent.STEPDEFINITIONS
{
    [Binding]
    public class ReteGivingHeaderSteps
    {
        ReteGivingHeaderPage reteGivingHeaderPage;

        public ReteGivingHeaderSteps()
        {
            reteGivingHeaderPage = new ReteGivingHeaderPage();
        }

        [When(@"a user clicks About us")]
        public void WhenAUserClicksAboutUs()
        {
            reteGivingHeaderPage.ClickAboutUs();
        }

        [When(@"a user clicks Pricing")]
        public void WhenAUserClicksPricing()
        {
            reteGivingHeaderPage.ClickPricing();
        }
        [Then(@"Pricing page displayed successfully")]
        public void ThenPricingPageDisplayedSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(reteGivingHeaderPage.SuccessDisplayed());
        }


        [When(@"a user clicks Event platform")]
        public void WhenAUserClicksEventPlatform()
        {
            reteGivingHeaderPage.ClickEventPlatForm();
        }
        
        [When(@"a user clicks Contact us")]
        public void WhenAUserClicksContactUs()
        {
            reteGivingHeaderPage.ContactUs();
        }
        [Then(@"About us page displayed successfully")]
        public void ThenAboutUsPageDisplayedSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(reteGivingHeaderPage.SuccessfulMessageDisplayed());
        }


                    
        [Then(@"Event plateform page displayed successfully")]
        public void ThenEventPlateformPageDisplayedSuccessfully()
        {
            
        }
        
        [Then(@"Contact us page displayed successfully")]
        public void ThenContactUsPageDisplayedSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(reteGivingHeaderPage.SusMessageDisplayed());
        }
    }
}
