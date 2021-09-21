/*
 * project = InstagramUsingPageFactoryAndLog4Net
 * Author = Lavanya Gollapudi
 * Created Date = 15/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AventStack.ExtentReports;

namespace Instagram_Selenium
{
    public class Tests : Base.BaseClass
    {
        ExtentReports report = ReportCreation.report();
        ExtentTest test;
        [Test]
        public void InputEmailAndPassword()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "INSTAGRAMAUTOMATION");

            Actions.ActionsDone.AssertAfterLauching(driver);

            Actions.ActionsDone.LoginToInstagram(driver);

            Actions.ActionsDone.TakeScreenshotOfInsta(driver);

            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

        [Test]
        public void ProfilePhotoUpdate()
        {
            ProfilePhotoClass.ProPhotoClass.photoUpload(driver);
        }
    }
}