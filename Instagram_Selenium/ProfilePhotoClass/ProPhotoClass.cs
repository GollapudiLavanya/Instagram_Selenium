/*
 * project = InstagramUsingPageFactoryAndAutoIT
 * Author = Lavanya Gollapudi
 * Created Date = 20/09/2021
 */

using Instagram_Selenium.UpdateProfilePic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AutoItX3Lib;
using NUnit.Framework;

namespace Instagram_Selenium.ProfilePhotoClass
{
    public class ProPhotoClass
    { 

        public static void photoUpload(IWebDriver driver)
        {
            ProfilePhoto pic = new ProfilePhoto(driver);
            
                pic.UN.SendKeys("ucs17139@rmd.ac.in");
                System.Threading.Thread.Sleep(1000);

                pic.PW.SendKeys("123456789ABCDHELLO");
                System.Threading.Thread.Sleep(1000);

                pic.loginButton.Click();
                System.Threading.Thread.Sleep(1000);

                pic.profileIcon.Click();
                System.Threading.Thread.Sleep(2000);

                pic.ProfileButton.Click();
                System.Threading.Thread.Sleep(2000);

                pic.PhotoUploadIcon.Click();
                System.Threading.Thread.Sleep(2000);

                pic.ChangeProfilePhoto.Click();
                System.Threading.Thread.Sleep(2000);

                pic.UploadPhoto.Click();
                System.Threading.Thread.Sleep(2000);

                AutoItX3 autoit = new AutoItX3();
                autoit.WinActivate("Open");
                autoit.Send(@"C:\Users\lavanya.g\Pictures\Saved Pictures\Flower.jpg");
                Thread.Sleep(3000);
                autoit.Send("{ENTER}");
                Thread.Sleep(5000);
        }
    }
}
