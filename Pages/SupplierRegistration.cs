using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDFramework.Pages
{
    public class SupplierRegistration
    {
        private IWebDriver driver;

        public SupplierRegistration(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement selectUserType => driver.FindElement(By.XPath("//label[@for='accounttype-60']"));
        public void forSelectUserType()
        {
            selectUserType.Click();
        }
        IWebElement txtCompanyName => driver.FindElement(By.Id("Company"));
        public void fortxtCompanyName(string CompanyName)
        {
            txtCompanyName.SendKeys(CompanyName);
        }
        IWebElement btnRadioGender => driver.FindElement(By.XPath("//label[normalize-space(text())='Male']"));
        public void forbtnRadioGender()
        {
            btnRadioGender.Click();
        }
        IWebElement txtFirstName => driver.FindElement(By.Id("FirstName"));
        public void fortxtFirstName(string firstName)
        {
            txtFirstName.SendKeys(firstName);
        }
        IWebElement txtLastName => driver.FindElement(By.Id("LastName"));
        public void fortxtLastName(string lastName)
        {
            txtLastName.SendKeys(lastName);
        }
        IWebElement txtEmail => driver.FindElement(By.Id("Email"));
        public void forEmail(string email)
        {
            txtEmail.SendKeys(email);
        }
        IWebElement txtConfirmEmail => driver.FindElement(By.Id("ConfirmEmail"));
        public void forConfirmEmail(string confirmEmail)
        {
            txtConfirmEmail.SendKeys(confirmEmail);
        }
        IWebElement txtPhone => driver.FindElement(By.Id("Phone"));
        public void fortxtPhone(string phone)
        {
            txtPhone.SendKeys(phone);
        }
        IWebElement txtOfficePhone => driver.FindElement(By.Id("OfficePhone"));
        public void forOfficePhone(string officePhone)
        {
            txtOfficePhone.SendKeys(officePhone);
        }
        IWebElement txtUserName => driver.FindElement(By.Id("Username"));
        public void fortxtUserName(string userName)
        {
            txtUserName.SendKeys(userName);
        }
        IWebElement txtPassword => driver.FindElement(By.Id("Password"));
        public void fortxtPassword(string password)
        {
            txtPassword.SendKeys(password);
        }
        IWebElement txtConfirmPassword => driver.FindElement(By.Id("ConfirmPassword"));
        public void fortxtConfirmPassword(string confirmPassword)
        {
            txtConfirmPassword.SendKeys(confirmPassword);
        }
        IWebElement selectorManufactureProduct => driver.FindElement(By.CssSelector("select#SelectedProductOfManufactureIds>option:nth-of-type(5)"));
        public void forSelectManufacturerProduct()
        {
            selectorManufactureProduct.Click();
        }
        IWebElement drpdwnHearAbout => driver.FindElement(By.Id("ReferrerTypeId"));
        public void fordrpdwnHearAbout(string HearAbout)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", drpdwnHearAbout);
            SelectElement selectOption = new SelectElement(drpdwnHearAbout);
            selectOption.SelectByText(HearAbout);
        }
        IWebElement drpdwnCountry => driver.FindElement(By.Id("BillingAddress_CountryId"));
        public void fordrpdwnCountry(string Country)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", drpdwnCountry);
            SelectElement selectOption = new SelectElement(drpdwnCountry);
            selectOption.SelectByText(Country);
        }
        IWebElement drpdwnState => driver.FindElement(By.Id("BillingAddress_StateProvinceId"));
        public void fordrpdwnState(string State)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", drpdwnState);
            SelectElement selectOption = new SelectElement(drpdwnState);
            selectOption.SelectByText(State);
        }
        IWebElement txtCity => driver.FindElement(By.Id("BillingAddress_City"));
        public void fortxtcity(string City)
        {
            txtCity.SendKeys(City);
        }
        IWebElement txtAddress1 => driver.FindElement(By.Id("BillingAddress_Address1"));
        public void forAddress1(string Address1)
        {
            txtAddress1.SendKeys(Address1);
        }
        IWebElement txtAddress2 => driver.FindElement(By.Id("BillingAddress_Address2"));
        public void forAddress2(string Address2)
        {
            txtAddress2.SendKeys(Address2);
        }
        IWebElement txtpostalCode => driver.FindElement(By.Id("BillingAddress_ZipPostalCode"));
        public void fortxtPostalCode(string Zip)
        {
            txtpostalCode.SendKeys(Zip);
        }
        IWebElement txtFaxNumber => driver.FindElement(By.Id("BillingAddress_FaxNumber"));
        public void fortxtFaxNumber(string FaxNumber)
        {
            txtFaxNumber.SendKeys(FaxNumber);
        }
        IWebElement checkShippingAsBilling => driver.FindElement(By.Id("SameAsBilling"));
        public void forcheckShippingAsBilling()
        {
            checkShippingAsBilling.Click();
        }
        IWebElement btnRegister => driver.FindElement(By.Id("register-button"));
        public void forbtnRegister()
        {
            btnRegister.Click();
        }


        //Admin Approval.....


        IWebElement btnlogin => driver.FindElement(By.CssSelector("a.ico-login"));
        public void forbtnLogin()
        {
            btnlogin.Click();
        }
        IWebElement txtAdminEmail => driver.FindElement(By.Id("Email"));
        public void fortxtAdminEmail(string AdminEmail)
        {
            txtAdminEmail.Clear();
            txtAdminEmail.SendKeys(AdminEmail);
        }
        IWebElement txtAdminPass => driver.FindElement(By.Id("Password"));
        public void fortxtAdminPassword(string AdminPassword)
        {
            txtAdminPass.Clear();
            txtAdminPass.SendKeys(AdminPassword);
        }
        IWebElement btnAdminLogin => driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
        public void forbtnAdminLogin()
        {
            btnAdminLogin.Submit();
        }
        IWebElement btnAdministrator => driver.FindElement(By.XPath("//a[normalize-space(text())='Administration']"));
        public void forbtnAdministrator()
        {
            btnAdministrator.Click();
        }
        IWebElement drpdwnCustomer => driver.FindElement(By.XPath("/html/body/div[3]/aside/div/div[4]/div/div/nav/ul/li[4]/a"));
        public void fordrpdwnCustomer()
        {
            drpdwnCustomer.Click();
        }
        IWebElement clickCustomer => driver.FindElement(By.XPath("/html/body/div[3]/aside/div/div[4]/div/div/nav/ul/li[4]/ul/li[1]/a"));
        public void forClickCustomer()
        {
            clickCustomer.Click();
        }
        IWebElement btnedit => driver.FindElement(By.XPath("//table[@id='customers-grid']/tbody[1]/tr[1]/td[8]/a[1]"));
        public void forbtnedit()
        {
            btnedit.Click();
        }
        IWebElement btnactive => driver.FindElement(By.Id("Active"));
        public void forbtnActiveAccount()
        {
            btnactive.Click();
        }
        IWebElement btnsave => driver.FindElement(By.Name("save"));
        public void forbtnSaveSupplier()
        {
            btnsave.Click();
        }
        IWebElement btnPublicStore => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));
        public void forbtnPublicStore()
        {
            btnPublicStore.Click();
        }
        IWebElement btnlogoutAdmin => driver.FindElement(By.XPath("(//a[@class='ico-logout'])[1]"));
        public void forbtnlogoutAdmin()
        {
            btnlogoutAdmin.Click();
        }

        // Supplier Login...

        IWebElement btnloginSupplier => driver.FindElement(By.CssSelector("a.ico-login"));
        public void forbtnSupplierLogin()
        {
            btnloginSupplier.Click();
        }
        IWebElement txtSupplierEmail => driver.FindElement(By.Id("Email"));
        public void fortxtSupplierEmail(string email)
        {
            txtSupplierEmail.Clear();
            txtSupplierEmail.SendKeys(email);
        }
        IWebElement txtSupplierPass => driver.FindElement(By.Id("Password"));
        public void fortxtSupplierPassword(string password)
        {
            txtSupplierPass.Clear();
            txtSupplierPass.SendKeys(password);
        }
        IWebElement btnSupplierLogin => driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
        public void forSupplierLogin()
        {
            btnSupplierLogin.Submit();
        }
        IWebElement btnSupplierAccount => driver.FindElement(By.XPath("(//a[@class='ico-account'])[1]"));
        public void forbtnSupplierAccount()
        {
            btnSupplierAccount.Click();
        }
        IWebElement btnmyproduct => driver.FindElement(By.XPath("//a[normalize-space(text())='Your products']"));
        public void forbtnmyproduct()
        {
            btnmyproduct.Click();
        }
        IWebElement btntestlawenforcement => driver.FindElement(By.XPath("(//span[@class='category-name'])[2]"));
        public void forbtntestlawenforcement()
        {
            btntestlawenforcement.Click();
        }
        IWebElement btntestLoanerform => driver.FindElement(By.XPath("(//a[@class='button-1'])[3]"));
        public void forbtntestLoanerform()
        {
            btntestLoanerform.Click();
        }
        IWebElement btnsupplierlogout => driver.FindElement(By.XPath("(//a[@class='ico-logout'])[1]"));
        public void forSupplierLogout()
        {
            btnsupplierlogout.Click();
        }
    }
}
