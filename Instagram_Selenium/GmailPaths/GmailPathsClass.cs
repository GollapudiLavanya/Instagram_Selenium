/*
 * project = GmailUsingPageFactoryAndAutoIT
 * Author = Lavanya Gollapudi
 * Created Date = 21/09/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Instagram_Selenium.GmailPaths
{
    public class GmailPathsClass
    {
        public GmailPathsClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "identifierId")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Next')]")]
        [CacheLookup]
        public IWebElement continuebtn;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement pwd;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Next')]")]
        [CacheLookup]
        public IWebElement Nextbtn;

        [FindsBy(How = How.XPath, Using = "//body/div[7]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]")]
        [CacheLookup]
        public IWebElement ComposeIcon;

        [FindsBy(How = How.Name, Using = "to")]
        [CacheLookup]
        public IWebElement ToButton;

        [FindsBy(How = How.Name, Using = "subjectbox")]
        [CacheLookup]
        public IWebElement SubjectButton;

        [FindsBy(How = How.XPath, Using = "//*[@class='a1 aaA aMZ']")]
        [CacheLookup]
        public IWebElement Attachbtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='T-I J-J5-Ji aoO v7 T-I-atl L3']")]
        [CacheLookup]
        public IWebElement Sendbtn;

    }
}
