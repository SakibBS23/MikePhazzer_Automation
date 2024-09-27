using OpenQA.Selenium;
using SpecFlowBDDFramework.Model;
using SpecFlowBDDFramework.Pages;
using SpecFlowBDDFramework.Utility;
using SpecFlowBDDFramework.Utility.DataProvider;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDFramework.StepDefinitions
{
    [Binding]
    public class LawEnforcementRegStepDefinitions
    {
        private IWebDriver driver;
        public LawEnforcementRegStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"\[User Go to Home]")]
        public void GivenUserGoToHome()
        {
            driver.Url = ConfigReader.GetInstance().GetBaseUrl();
        }

        [When(@"\[User click on register button]")]
        public void WhenUserClickOnRegisterButton()
        {
            IWebElement btn = driver.FindElement(By.XPath("//a[normalize-space(text())='Register']"));
            btn.Click();
            Thread.Sleep(2000);
        }

        [Then(@"\[User fill the registration form]")]
        public void ThenUserFillTheRegistrationForm()
        {
            string rootPath = HelperUtility.GetInstance().GetProjectRootPath();

            var lawRegisterForm = new LawEnforcementRegistration(driver);

            lawRegisterForm.forSelectUserType();

            string jsonFilePathLaw = "TestData\\LawEnforcementRegistration.json";
            string _jsonFilePathLaw = Path.Combine(rootPath, jsonFilePathLaw);
            Console.WriteLine(_jsonFilePathLaw);
            LawEnforcementRegistrationAddItemModel lawEnforcementRegistrationAddItemModel = null;
            try
            {
                lawEnforcementRegistrationAddItemModel = JSONFileReader.ReadJsonFile<LawEnforcementRegistrationAddItemModel>(_jsonFilePathLaw);
                Console.WriteLine(lawEnforcementRegistrationAddItemModel);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            lawRegisterForm.fortxtCompanyName(lawEnforcementRegistrationAddItemModel.CompanyName);
            Thread.Sleep(2000);
            lawRegisterForm.forbtnRadioGender();
            Thread.Sleep(2000);
            lawRegisterForm.fortxtFirstName(lawEnforcementRegistrationAddItemModel.firstName);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtLastName(lawEnforcementRegistrationAddItemModel.lastName);
            Thread.Sleep(2000);
            lawRegisterForm.forEmail(lawEnforcementRegistrationAddItemModel.email);
            Thread.Sleep(2000);
            lawRegisterForm.forConfirmEmail(lawEnforcementRegistrationAddItemModel.confirmEmail);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtPhone(lawEnforcementRegistrationAddItemModel.phone);
            Thread.Sleep(2000);
            lawRegisterForm.forOfficePhone(lawEnforcementRegistrationAddItemModel.officePhone);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtUserName(lawEnforcementRegistrationAddItemModel.userName);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtPassword(lawEnforcementRegistrationAddItemModel.password);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtConfirmPassword(lawEnforcementRegistrationAddItemModel.confirmPassword);
            Thread.Sleep(2000);
            lawRegisterForm.forSelectInterestProduct();
            Thread.Sleep(2000);
            lawRegisterForm.forSelectLawEnforcementType();
            Thread.Sleep(2000);
            lawRegisterForm.fordrpdwnHearAbout(lawEnforcementRegistrationAddItemModel.HearAbout);
            Thread.Sleep(2000);
            lawRegisterForm.fordrpdwnCountry(lawEnforcementRegistrationAddItemModel.Country);
            Thread.Sleep(2000);
            lawRegisterForm.fordrpdwnState(lawEnforcementRegistrationAddItemModel.State);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtcity(lawEnforcementRegistrationAddItemModel.City);
            Thread.Sleep(2000);
            lawRegisterForm.forAddress1(lawEnforcementRegistrationAddItemModel.Address1);
            Thread.Sleep(2000);
            lawRegisterForm.forAddress2(lawEnforcementRegistrationAddItemModel.Address2);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtPostalCode(lawEnforcementRegistrationAddItemModel.Zip);
            Thread.Sleep(2000);
            lawRegisterForm.fortxtFaxNumber(lawEnforcementRegistrationAddItemModel.FaxNumber);
            Thread.Sleep(2000);
            lawRegisterForm.forcheckShippingAsBilling();
            Thread.Sleep(2000);
            lawRegisterForm.forbtnRegister();
        }

        [Then(@"\[Admin approve the account]")]
        public void ThenAdminApproveTheAccount()
        {
            string rootPath = HelperUtility.GetInstance().GetProjectRootPath();

            var adminform = new LawEnforcementRegistration(driver);

            string jsonFilePathLaw = "TestData\\LawEnforcementRegistration.json";
            string _jsonFilePathLaw = Path.Combine(rootPath, jsonFilePathLaw);
            Console.WriteLine(_jsonFilePathLaw);
            LawEnforcementRegistrationAddItemModel lawEnforcementRegistrationAddItemModel = null;
            try
            {
                lawEnforcementRegistrationAddItemModel = JSONFileReader.ReadJsonFile<LawEnforcementRegistrationAddItemModel>(_jsonFilePathLaw);
                Console.WriteLine(lawEnforcementRegistrationAddItemModel);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            adminform.forbtnLogin();
            Thread.Sleep(2000);
            adminform.fortxtAdminEmail(lawEnforcementRegistrationAddItemModel.AdminEmail);
            Thread.Sleep(2000);
            adminform.fortxtAdminPassword(lawEnforcementRegistrationAddItemModel.AdminPassword);
            Thread.Sleep(2000);
            adminform.forbtnAdminLogin();
            Thread.Sleep(2000);
            adminform.forbtnAdministrator();
            Thread.Sleep(2000);
            adminform.fordrpdwnCustomer();
            Thread.Sleep(2000);
            adminform.forClickCustomer();
            Thread.Sleep(2000);
            adminform.forbtnedit();
            Thread.Sleep(2000);
            adminform.forbtnActiveAccount();
            Thread.Sleep(2000);
            adminform.forbtnSaveLaw();
            Thread.Sleep(2000);
            adminform.forbtnPublicStore();
            Thread.Sleep(2000);
            adminform.forbtnlogoutAdmin();
        }

        [Then(@"\[User check the user authentication]")]
        public void ThenUserCheckTheUserAuthentication()
        {
            string rootPath = HelperUtility.GetInstance().GetProjectRootPath();

            var lawIdentify = new LawEnforcementRegistration(driver);

            string jsonFilePathLaw = "TestData\\LawEnforcementRegistration.json";
            string _jsonFilePathLaw = Path.Combine(rootPath, jsonFilePathLaw);
            Console.WriteLine(_jsonFilePathLaw);
            LawEnforcementRegistrationAddItemModel lawEnforcementRegistrationAddItemModel = null;
            try
            {
                lawEnforcementRegistrationAddItemModel = JSONFileReader.ReadJsonFile<LawEnforcementRegistrationAddItemModel>(_jsonFilePathLaw);
                Console.WriteLine(lawEnforcementRegistrationAddItemModel);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            lawIdentify.forbtnLawLogin();
            Thread.Sleep(3000);
            lawIdentify.fortxtLawEmail(lawEnforcementRegistrationAddItemModel.email);
            Thread.Sleep(3000);
            lawIdentify.fortxtLawPassword(lawEnforcementRegistrationAddItemModel.password);
            Thread.Sleep(3000);
            lawIdentify.forLawLogin();
            Thread.Sleep(3000);
            lawIdentify.forbtnLawEnforcement();
            Thread.Sleep(3000);
            lawIdentify.forbtnLoanerForm();
            Thread.Sleep(3000);
            lawIdentify.foragainbtnLawEnforcement();
            Thread.Sleep(3000);
            lawIdentify.forbtnEvaluationForm();
            Thread.Sleep(3000);
            lawIdentify.forbtnlogoutLaw();
            
        }
    }
}
