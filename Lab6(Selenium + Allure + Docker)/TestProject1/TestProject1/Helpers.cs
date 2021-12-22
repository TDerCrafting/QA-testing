using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace QA_testing_project
{
    internal class Helpers
    {

        public static void ClearAndType(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
