using NUnit.Framework;
// using OpenQA.Selenium.Support.UI;
// using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
// using System;
// using System.Diagnostics;
// using System.Threading;
// using System.Collections.Generic;

namespace Automation
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestSignIn()
        {
            driver.Url = "https://www.wholefoodsmarket.com/";

        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}