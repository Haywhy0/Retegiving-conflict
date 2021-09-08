using OpenQA.Selenium;
using ReteGivingEvent.HOOK;
using ReteGivingEvent.PAGEOBJECTS;
using System;
using TechTalk.SpecFlow;

namespace ReteGivingEvent.STEPDEFINITIONS
{
    [Binding]
    public class EventPlatformButtonSteps
    {

        public IWebDriver driver = BaseTest.driver;
        EventPlatformButtonPage _eventPlatformButtonPage = new EventPlatformButtonPage();

        [When(@"user clicks on event platform button on the header")]
        public void WhenUserClicksOnEventPlatformButtonOnTheHeader()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user clicks on any other button apart from the event platform button on the header")]
        public void WhenUserClicksOnAnyOtherButtonApartFromTheEventPlatformButtonOnTheHeader()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be taken to the event platform page to view the product")]
        public void ThenIShouldBeTakenToTheEventPlatformPageToViewTheProduct()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should not be taken to the event platform page to view the product")]
        public void ThenIShouldNotBeTakenToTheEventPlatformPageToViewTheProduct()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
