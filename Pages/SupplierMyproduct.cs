using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDFramework.Pages
{
    public class SupplierMyproduct
    {
        private IWebDriver driver;
        public SupplierMyproduct(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement btnMyAccount => driver.FindElement(By.XPath("(//a[@class='ico-account'])[1]"));

    }
}
