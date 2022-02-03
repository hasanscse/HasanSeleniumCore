using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace HasanSeleniumCore
{
    public class Tests
    {

       
        [SetUp]
        public void Setup()
        {

            Console.WriteLine("Setup");
           }

        [Test]
        public void Test1()
        {

            IWebDriver webDriver = new ChromeDriver(@"F:\");
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com");
            webDriver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(4000);

            IWebElement InkLogin = webDriver.FindElement(By.LinkText("Login"));
            InkLogin.Click();
            System.Threading.Thread.Sleep(4000);


            var txtUserName = webDriver.FindElement(By.Name("UserName"));
            txtUserName.SendKeys("ibrahim");
            System.Threading.Thread.Sleep(4000);



            var txtPassword = webDriver.FindElement(By.Name("Password"));
            txtPassword.SendKeys("Automation2@");
            System.Threading.Thread.Sleep(4000);

            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            System.Threading.Thread.Sleep(4000);


            Console.WriteLine("test1, login successful");



            Assert.Pass();
        }
    }
}