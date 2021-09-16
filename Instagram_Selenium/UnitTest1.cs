/*
 * project = InstagramUsingPageFactory
 * Author = Lavanya Gollapudi
 * Created Date = 15/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Instagram_Selenium
{
    public class Tests : Base.BaseClass
    {
        [Test]
        public void InputEmailAndPassword()
        {
            Actions.ActionsDone.AssertAfterLauching(driver);
            Actions.ActionsDone.LoginToInstagram(driver);
        }
    }
}