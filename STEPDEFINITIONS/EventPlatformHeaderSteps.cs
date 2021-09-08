using OpenQA.Selenium;
using ReteGivingEvent.HOOK;
using ReteGivingEvent.PAGEOBJECTS;
using System;
using TechTalk.SpecFlow;

namespace ReteGivingEvent.STEPDEFINITIONS
{
    [Binding]
    public class EventPlatformHeaderSteps
    {

        public IWebDriver driver = BaseTest.driver;
        EventPlatformHeaderPage _eventPlatformHeaderPage = new EventPlatformHeaderPage();

        [Given(@"the header contain  Home section")]
        public void GivenTheHeaderContainHomeSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the header contain Greetings section")]
        public void GivenTheHeaderContainGreetingsSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the header contain Gallery section")]
        public void GivenTheHeaderContainGallerySection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the header contain Donation")]
        public void GivenTheHeaderContainDonation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Home button is clicked at any of the section")]
        public void WhenHomeButtonIsClickedAtAnyOfTheSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Home button is not clicked at any of the section")]
        public void WhenHomeButtonIsNotClickedAtAnyOfTheSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Platforms are accessible")]
        public void ThenPlatformsAreAccessible()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Platforms are  not accessible")]
        public void ThenPlatformsAreNotAccessible()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
