using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class GoogleTest
    {
        IWebDriver driver;
        [TestMethod]
        public void OpenGoogle()
        {
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();

        }
    }
}
