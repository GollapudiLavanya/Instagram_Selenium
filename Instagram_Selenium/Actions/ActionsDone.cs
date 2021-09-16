/*
 * project = InstagramUsingPageFactory
 * Author = Lavanya Gollapudi
 * Created Date = 15/09/2021
 */

using Instagram_Selenium.page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace Instagram_Selenium.Actions
{
    public class ActionsDone
    {
        public static Login_page login;
        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Instagram";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToInstagram(IWebDriver driver)
        {
            login = new Login_page(driver);

            login.UN.SendKeys("ucs17139@rmd.ac.in");
            System.Threading.Thread.Sleep(6000);

            login.PW.SendKeys("123456789ABCDHELLO");
            System.Threading.Thread.Sleep(6000);

            login.loginButton.Click();
            System.Threading.Thread.Sleep(8000);

        }
    }
}