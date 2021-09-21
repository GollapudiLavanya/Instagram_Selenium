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

            log.Debug("navigating to url");

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