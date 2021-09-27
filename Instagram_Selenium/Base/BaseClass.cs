/*
 * project = InstagramUsingPageFactoryAndLog4Net
 * Author = Lavanya Gollapudi
 * Created Date = 15/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using log4net;
using log4net.Repository;
using System.IO;
using System.Reflection;
using System.Configuration;

namespace Instagram_Selenium.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());


        [SetUp]
        public void Setup()
        {
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);

            log.Info("Entering Setup");

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("--disable-notifications");

            driver = new ChromeDriver(chromeOptions);
            driver.Url = "https://www.instagram.com/";
            driver.Url = "https://accounts.google.com/AccountChooser/identifier?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=AccountChooser";
            log.Info("navigating to url");

            //string fromemail = ConfigurationManager.AppSettings.Get("Email");
                
            //string Password=ConfigurationManager.AppSettings.Get("pwd");

            log.Info("Exiting setup");

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