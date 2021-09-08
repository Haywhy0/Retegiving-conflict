using NUnit.Framework;
using OpenQA.Selenium;
using ReteGivingEvent.Hooks;
using ReteGivingEvent.PAGEOBJECTS;
using System;
using TechTalk.SpecFlow;

namespace ReteGivingEvent.STEPDEFINITIONS
{
    [Binding]
    public class BackGroundImageSteps
    {

        BackGroundImagePage backGroundImagePage;

        public BackGroundImageSteps()
        {
            backGroundImagePage = new BackGroundImagePage();
        }

        [Given(@"a user navigates to ""(.*)""")]
        public void GivenAUserNavigatesTo(string url)
        {
            backGroundImagePage.Navigate(url);
        }


        [Then(@"background image displayed successfully")]
        public void ThenBackgroundImageDisplayedSuccessfully()
        {
            Assert.IsTrue(backGroundImagePage.successImageDisplayed());
        }
    }
}
