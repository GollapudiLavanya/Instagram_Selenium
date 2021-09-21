/*
 * project = InstagramUsingPageFactoryAndLog4Net
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
            System.Threading.Thread.Sleep(1000);

            login.PW.SendKeys("123456789ABCDHELLO");
            System.Threading.Thread.Sleep(1000);

            login.loginButton.Click();
            System.Threading.Thread.Sleep(1000);

        }
        public static void keys(IWebDriver driver)
        {
            IWebElement MyElement = driver.FindElement(By.XPath("//*[@class='_8-yf5 ']"));
            System.Threading.Thread.Sleep(300);
        }
        public static void TakeScreenshotOfInsta(IWebDriver driver)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\lavanya.g\source\repos\Instagram_Selenium\Instagram_Selenium\Screenshots\.jpg");
            System.Threading.Thread.Sleep(1000);
        }
    }
}