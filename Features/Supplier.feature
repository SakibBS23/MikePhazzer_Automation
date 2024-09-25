Feature: Supplier

Supplier registered and apply the all roles and responsibilities for him

@Supplier_Regitration
Scenario: Negigate the registration process
	Given Nevigate to the home page
	When [Nevigate to click on the Register url]
	Then [choose the supplier option]
	And [fill all requirement and click on register]
	Then [admin login and approve the account]

