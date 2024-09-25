using OpenQA.Selenium;
using SpecFlowBDDFramework.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDFramework.StepDefinitions
{
    [Binding]
    public class SupplierLoginStepDefinitions
    {
        private IWebDriver driver;
        private string supplierEmail = ConfigReader.GetInstance().GetAnyPropValue("supplierlogin");
        private string supplierPass = ConfigReader.GetInstance().GetAnyPropValue("supplierpass");
        public SupplierLoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            
    }
        [Given(@"\[go to home page]")]
        public void GivenGoToHomePage()
        {
            driver.Url = ConfigReader.GetInstance().GetBaseUrl();
        }

        [When(@"\[go to login and access to the account]")]
        public void WhenGoToLoginAndAccessToTheAccount()
        {
            IWebElement btnlogin = driver.FindElement(By.CssSelector("a.ico-login"));
            btnlogin.Click();
            IWebElement txtsupplierEmail = driver.FindElement(By.Id("Email"));
            txtsupplierEmail.Clear();
            txtsupplierEmail.SendKeys(supplierEmail);
            Thread.Sleep(2000);
            IWebElement txtsupplierPass = driver.FindElement(By.Id("Password"));
            txtsupplierPass.Clear();
            txtsupplierPass.SendKeys(supplierPass);
            Thread.Sleep(2000);
            IWebElement btnLogin = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            btnLogin.Submit();
            Thread.Sleep(3000);
        }

        [Then(@"\[Go to supplier product request page]")]
        public void ThenGoToSupplierProductRequestPage()
        {
            IWebElement btnmyAccount = driver.FindElement(By.XPath("(//a[@class='ico-account'])[1]"));
            btnmyAccount.Click();
            IWebElement btnmyproduct = driver.FindElement(By.XPath("//a[normalize-space(text())='Your products']"));
            btnmyproduct.Click();
        }
    }
}
