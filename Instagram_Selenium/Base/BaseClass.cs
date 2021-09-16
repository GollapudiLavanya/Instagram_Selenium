/*
 * project = InstagramUsingPageFactory
 * Author = Lavanya Gollapudi
 * Created Date = 15/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Instagram_Selenium.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.instagram.com/";

            //Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8000);

            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            driver.Quit();
        }
    }
}