Feature: Supplier-MyProduct

A short summary of the supplier>> my product feature

@Supplier_MyProduct
Scenario: [Supplier my product feature configuration]
	Given [User Go to the home page]
	When [User login as a supplier]
	Then [User create product]
	And [Admin login and approve the request]
	Then [User login again and see the product and edit it]
	Then [Admin again login and approve the change and admin publish the product]
	Then [Product available in the storefront]
