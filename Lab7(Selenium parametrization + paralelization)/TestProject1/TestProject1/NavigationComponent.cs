using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_testing_project
{
    public class NavigationComponent
    {
        private IWebDriver driver;
        
        public  NavigationComponent(IWebDriver driver) => this.driver = driver;

        public IWebElement OwnerTab() => driver.FindElement(By.CssSelector(".ownerTab"));

        public IWebElement OwnerCreateTab() => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));

       public void OpenCreateOwnerTab()
        {
            this.OwnerTab().Click();

            this.OwnerCreateTab().Click();
            
        }

        public IWebElement VetTab() => driver.FindElement(By.CssSelector(".vetsTab"));
        public IWebElement VetListButton() => driver.FindElement(By.CssSelector(".open li:nth-child(1) > a"));
        public IWebElement VetCreateButton() => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));

        public void OpenVetTab()
        {
            this.VetTab().Click();

            this.VetListButton().Click();
        }

        public IWebElement PetTypeTab() => driver.FindElement(By.CssSelector("li:nth-child(4) > a"));

        public void OpenPetTypeTab()
        {
        this.PetTypeTab().Click();
        }


        public void OpenVetCreateTab()
        {
            this.VetTab().Click();
            this.VetCreateButton().Click();
        }

    }
}
