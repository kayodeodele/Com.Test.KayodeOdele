Feature: PracticeStore
	As a customer
	I want to access the practice store
	So I can order items and update my details

Background: 
	Given I have navigated to the store website
	And I click Sigh in
	And I enter my email kayode.odele@yahoo.co.uk and password Passw0rd+ 
	And I Click Sign in button
	Then I should land on the Order page

@mytag
Scenario: Order TShirt and verify in order history		
	When I select TShirt link 
	And I hover over the available product
	And I select Add to Cart
	And I select Proceed to checkout
	Then I should land on the Shopping-Cart Summary page
	When I select Proceed to checkout on Shopping cart	
	And I select Proceed to checkout after Address check	
	And I tick the terms of service for shipping
	And I select Proceed to checkout on the Shipping page
	And I select pay by wire
	Then I should land on the Order Summary page
	When I confirm my order 
	Then I should land on the Order Confirmation page
	When I select to view my account
	Then I should land on the Order page
	When I select Order history and details
	Then I should see my orders listed	

Scenario: Update first name in my account
	When I select to view my account
	And I select my personal information
	And I update my firstname to Engineer
	And I enter my password Passw0rd+
	And I click Save
	Then I should get an alert that the update is successful

	


	





	