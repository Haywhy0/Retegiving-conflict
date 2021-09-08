Feature: ReteGivingHeader
	Simple calculator for adding two numbers


	Background: ReteGivingHeader
	Given a user navigates to "https://retegiving.com/"

@mytag
Scenario: About us
	When a user clicks About us
	Then About us page displayed successfully


Scenario: Pricing
     When a user clicks Pricing
	 Then Pricing page displayed successfully


#Scenario: Event Platform
      #When a user clicks Event platform
	  #Then Event plateform page displayed successfully


Scenario: Contact us
     When a user clicks Contact us
	 Then Contact us page displayed successfully 
