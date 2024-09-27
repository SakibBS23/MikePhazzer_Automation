Feature: LawEnforcementReg

Law inforcement registration feature

@LawInforcementRegistration
Scenario: [LawInforcement account can Register and login]
	Given [User Go to Home]
	When [User click on register button]
	Then [User fill the registration form]
	And [Admin approve the account]
	Then [User check the user authentication]

