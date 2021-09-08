Feature: CookieBanner
As a User,I want to be able to view the cookie banner
So that I know that the company is GDPR compliant and,  
I have control over my data being collected on the website

@mytag
Scenario: verify company is GDPR compliance
	Given User navigates to  https://retegiving.com/
	When User  clicks on cookie settings
	And User clicks on save and accept
	#And User clicks on accept button
	#Then Company is GDPR compliance