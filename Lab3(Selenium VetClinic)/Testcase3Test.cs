// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Testcase3Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void testcase3() {
    driver.Navigate().GoToUrl("http://20.50.171.10:8080//");
    driver.Manage().Window.Size = new System.Drawing.Size(816, 766);
    driver.FindElement(By.CssSelector("li:nth-child(4) > a")).Click();
    driver.FindElement(By.CssSelector(".addPet")).Click();
    driver.FindElement(By.Id("name")).Click();
    driver.FindElement(By.Id("name")).SendKeys("Tiger");
    driver.FindElement(By.CssSelector(".saveType")).Click();
    driver.Close();
  }
}
