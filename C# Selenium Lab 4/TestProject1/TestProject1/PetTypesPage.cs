using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace QA_testing_project
{
    public class PetTypesPage : page_object
     {
       
        public PetTypesPage(IWebDriver driver) : base(driver) { }

        public void OpenPetTypesPage()
        {
            driver.FindElement(By.CssSelector("li:nth-child(4) > a")).Click();
        }

       

        public void ClickOnDeleteTypeButton() => driver.FindElement(By.CssSelector("tr:nth-child(1) .deletePet")).Click();


    }
}
