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
    public class SupplierStepDefinitions
    {
        private IWebDriver driver;
        private string supplierEmail = ConfigReader.GetInstance().GetAnyPropValue("supplierlogin");
        private string supplierPass = ConfigReader.GetInstance().GetAnyPropValue("supplierpass");
        private string adminEmail = ConfigReader.GetInstance().GetAnyPropValue("adminlogin");
        private string adminPass = ConfigReader.GetInstance().GetAnyPropValue("adminpass");

        public SupplierStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"Nevigate to the home page")]
        public void GivenNevigateToTheHomePage()
        {
            driver.Url = ConfigReader.GetInstance().GetBaseUrl();
        }


        [When(@"\[Nevigate to click on the Register url]")]
        public void WhenNevigateToClickOnTheRegisterUrl()
        {
            IWebElement btn = driver.FindElement(By.XPath("//a[normalize-space(text())='Register']"));
            btn.Click();
            Thread.Sleep(2000);
        }

        [Then(@"\[choose the supplier option]")]
        public void ThenChooseTheSupplierOption()
        {
            string rootPath = HelperUtility.GetInstance().GetProjectRootPath();

            var supplierRegisterForm = new SupplierRegistration(driver);

            supplierRegisterForm.forSelectUserType();

            string jsonFilePathsupplier = "TestData\\SupplierRegistration.json";
            string _jsonFilePathSupplier = Path.Combine(rootPath, jsonFilePathsupplier);
            Console.WriteLine(_jsonFilePathSupplier);
            SupplierRegistrationAddItemModel supplierRegistrationAddItemModel = null;
            try
            {
                supplierRegistrationAddItemModel = JSONFileReader.ReadJsonFile<SupplierRegistrationAddItemModel>(_jsonFilePathSupplier);
                Console.WriteLine(supplierRegistrationAddItemModel);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            supplierRegisterForm.fortxtCompanyName(supplierRegistrationAddItemModel.CompanyName);
            Thread.Sleep(2000);
            supplierRegisterForm.forbtnRadioGender();
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtFirstName(supplierRegistrationAddItemModel.firstName);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtLastName(supplierRegistrationAddItemModel.lastName);
            Thread.Sleep(2000);
            supplierRegisterForm.forEmail(supplierRegistrationAddItemModel.email);
            Thread.Sleep(2000);
            supplierRegisterForm.forConfirmEmail(supplierRegistrationAddItemModel.confirmEmail);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtPhone(supplierRegistrationAddItemModel.phone);
            Thread.Sleep(2000);
            supplierRegisterForm.forOfficePhone(supplierRegistrationAddItemModel.officePhone);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtUserName(supplierRegistrationAddItemModel.userName);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtPassword(supplierRegistrationAddItemModel.password);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtConfirmPassword(supplierRegistrationAddItemModel.confirmPassword);
            Thread.Sleep(2000);
            supplierRegisterForm.forSelectManufacturerProduct();
            Thread.Sleep(2000);
            supplierRegisterForm.fordrpdwnHearAbout(supplierRegistrationAddItemModel.HearAbout);
            Thread.Sleep(2000);
            supplierRegisterForm.fordrpdwnCountry(supplierRegistrationAddItemModel.Country);
            Thread.Sleep(2000);
            supplierRegisterForm.fordrpdwnState(supplierRegistrationAddItemModel.State);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtcity(supplierRegistrationAddItemModel.City);
            Thread.Sleep(2000);
            supplierRegisterForm.forAddress1(supplierRegistrationAddItemModel.Address1);
            Thread.Sleep(2000);
            supplierRegisterForm.forAddress2(supplierRegistrationAddItemModel.Address2);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtPostalCode(supplierRegistrationAddItemModel.Zip);
            Thread.Sleep(2000);
            supplierRegisterForm.fortxtFaxNumber(supplierRegistrationAddItemModel.FaxNumber);
            Thread.Sleep(2000);
            supplierRegisterForm.forcheckShippingAsBilling();
            Thread.Sleep(2000);
            supplierRegisterForm.forbtnRegister();
        }

        [Then(@"\[fill all requirement and click on register]")]
        public void ThenFillAllRequirementAndClickOnRegister()
        {
            string rootPath = HelperUtility.GetInstance().GetProjectRootPath();
            var adminform = new SupplierRegistration(driver);

            string jsonFilePathsupplier = "TestData\\SupplierRegistration.json";
            string _jsonFilePathSupplier = Path.Combine(rootPath, jsonFilePathsupplier);
            Console.WriteLine(_jsonFilePathSupplier);
            SupplierRegistrationAddItemModel supplierRegistrationAddItemModel = null;
            try
            {
                supplierRegistrationAddItemModel = JSONFileReader.ReadJsonFile<SupplierRegistrationAddItemModel>(_jsonFilePathSupplier);
                Console.WriteLine(supplierRegistrationAddItemModel);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            adminform.forbtnLogin();
            Thread.Sleep(2000);
            adminform.fortxtAdminEmail(supplierRegistrationAddItemModel.AdminEmail);
            Thread.Sleep(2000);
            adminform.fortxtAdminPassword(supplierRegistrationAddItemModel.AdminPassword);
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
            adminform.forbtnSaveSupplier();
            Thread.Sleep(2000);
            adminform.forbtnPublicStore();
            Thread.Sleep(2000);
            adminform.forbtnlogoutAdmin();
        }

        [Then(@"\[admin login and approve the account]")]
        public void ThenAdminLoginAndApproveTheAccount()
        {
            string rootPath = HelperUtility.GetInstance().GetProjectRootPath();
            var supplierIdentify = new SupplierRegistration(driver);

            string jsonFilePathsupplier = "TestData\\SupplierRegistration.json";
            string _jsonFilePathSupplier = Path.Combine(rootPath, jsonFilePathsupplier);
            Console.WriteLine(_jsonFilePathSupplier);
            SupplierRegistrationAddItemModel supplierRegistrationAddItemModel = null;
            try
            {
                supplierRegistrationAddItemModel = JSONFileReader.ReadJsonFile<SupplierRegistrationAddItemModel>(_jsonFilePathSupplier);
                Console.WriteLine(supplierRegistrationAddItemModel);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            supplierIdentify.forbtnSupplierLogin();
            supplierIdentify.fortxtSupplierEmail(supplierRegistrationAddItemModel.email);
            supplierIdentify.fortxtSupplierPassword(supplierRegistrationAddItemModel.password);
            supplierIdentify.forSupplierLogin();
            supplierIdentify.forbtnSupplierAccount();
            supplierIdentify.forbtnmyproduct();
            supplierIdentify.forbtntestlawenforcement();
            supplierIdentify.forbtntestLoanerform();
            supplierIdentify.forSupplierLogout();
        }
    }
}
