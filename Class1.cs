using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Net;
using System.Xml.Linq;

namespace Maria_Oliveira__8751749_Assignment3
{

    // Test1
    [TestFixture]
    public class ValidData_Age25_Experience3_Acdent0_Test1
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test1()
        {
            driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
            driver.Manage().Window.Size = new System.Drawing.Size(974, 816);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548 333 8820");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("finalQuote"));
            Assert.True(elements.Count > 0);
        }
    }

    // Test2
    [TestFixture]
    public class ValidData_Age25_Experience3_Acdent4_Test2
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test2()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(976, 816);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("4");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("finalQuote"));
            Assert.True(elements.Count > 0);
        }
    }

    // Test 3 
    [TestFixture]
    public class ValidData_Age35_Experience10_Acdent2_Test3
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test3()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("10");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("finalQuote"));
            Assert.True(elements.Count > 0);
        }
    }

    //Test 4

    [TestFixture]
    public class InvalidNumber_Test4
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test4()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(932, 816);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("phone-error"));
            Assert.True(elements.Count > 0);
        }
    }

    //Test 5
    [TestFixture]
    public class InvalidEmail_Test5
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test5()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(977, 816);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            {
                var element = driver.FindElement(By.Id("email"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.Id("email"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.Id("email"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("mwalleska");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("email-error"));
            Assert.True(elements.Count == 0);
        }
    }


    // Test6
    [TestFixture]
    public class InvalidPostalCode_Test6
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test6()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(932, 816);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("17");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("postalCode-error"));
            Assert.True(elements.Count > 0);
        }
    }
    //Test 7

    [TestFixture]
    public class noAge_Test7
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test7()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(758, 816);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("5");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("age-error"));
            Assert.True(elements.Count > 0);
        }
    }

    //Test 8
    [TestFixture]
    public class AccidentOmited_Test8
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test8()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(974, 816);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("37");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("8");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("accidents-error"));
            Assert.True(elements.Count > 0);
        }
    }


    //Test9

    [TestFixture]
    public class YearsOfDrivingOmitted_Test9
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test9()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.Manage().Window.Size = new System.Drawing.Size(932, 816);
            driver.FindElement(By.LinkText("prog2070a03/")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Maria");
            driver.FindElement(By.Id("lastName")).SendKeys("Oliveira");
            driver.FindElement(By.Id("address")).SendKeys("kingwood drive");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E2K2");
            driver.FindElement(By.Id("phone")).SendKeys("5483338820");
            driver.FindElement(By.Id("email")).SendKeys("mwalleska135246@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("548-333-8820");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 2K2");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("45");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("experience-error"));
            Assert.True(elements.Count > 0);
        }
    }
}
