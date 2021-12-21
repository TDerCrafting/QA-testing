using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace QA_testing_project
{
    public class page_object
    {
        protected IWebDriver driver;

        public page_object(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ChangeInputValue(By inputSelector, string newValue, bool overwrite)
        {
            var element = driver.FindElement(inputSelector);
            if (overwrite)
                element.Clear();

            element.SendKeys(newValue);
        }

        public bool IsElementVisible(By elementSelector)
        {
            try
            {
                return driver.FindElement(elementSelector) != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
