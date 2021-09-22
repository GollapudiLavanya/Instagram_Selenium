using Instagram_Selenium.GmailPaths;
using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using OpenQA.Selenium;
using NUnit.Framework;
using AutoItX3Lib;
using System.Threading;

namespace Instagram_Selenium.GmailActions
{
    public class GmailActionsClass
    {
        public static GmailPathsClass login;
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        public static void AssertAfterLauchingGmail(IWebDriver driver)
        {
            string title1 = "Gmail";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void LoginToGmail(IWebDriver driver)
        {

            login = new GmailPathsClass(driver);

            login.Email.SendKeys("ucs17139@rmd.ac.in");
            System.Threading.Thread.Sleep(1000);

            login.continuebtn.Click();
            System.Threading.Thread.Sleep(1000);

            login.pwd.SendKeys("123456789ABCDHELLO");
            System.Threading.Thread.Sleep(1000);

            login.Nextbtn.Click();
            System.Threading.Thread.Sleep(1000);

            log.Info("Logging in Succesfull");
            System.Threading.Thread.Sleep(1000);

            Assert.AreEqual(driver.Url, "https://mail.google.com/mail/u/0/#inbox");

            login.ComposeIcon.Click();
            System.Threading.Thread.Sleep(1000);

            login.ToButton.SendKeys("lavanyagollapudi5166@gmail.com");
            login.ToButton.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(1000);

            login.SubjectButton.SendKeys("Reports");
            System.Threading.Thread.Sleep(1000);

            login.Attachbtn.Click();
            System.Threading.Thread.Sleep(1000);

            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Open");
            autoit.Send(@"C:\Users\lavanya.g\source\repos\Instagram_Selenium\Instagram_Selenium\Reports\index.html");
            Thread.Sleep(3000);
            autoit.Send("{ENTER}");
            Thread.Sleep(5000);

            login.Sendbtn.Click();
            System.Threading.Thread.Sleep(1000);

            log.Info("Mail Sent Succesfully");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
