using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HamiltonMeng()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://lottery.broadwaydirect.com/show/hamilton-chicago/");
            string currentHandle = driver.CurrentWindowHandle;
            
            IWebElement enterNow = driver.FindElement(By.LinkText("Enter Now"));
            //enterNow.Click();

            if (enterNow != null)
            {
                // Store the current window handle so you can switch back to the
                // original window when you close the popup.
                //PopupWindowFinder finder = new PopupWindowFinder(driver);
                string href=enterNow.GetAttribute("href");
                driver.Navigate().GoToUrl(href);
               // string newHandle = finder.Click(enterNow);

                //driver.SwitchTo().Window(newHandle);
                IWebElement firstName = driver.FindElement(By.Id("dlslot_name_first"));
                firstName.SendKeys("Meng");
                IWebElement lastName = driver.FindElement(By.Id("dlslot_name_last"));
                lastName.SendKeys("Fang");
                SelectElement ticket = new SelectElement( driver.FindElement(By.Id("dlslot_ticket_qty")));
                //FindElement(By.CssSelector("option[value='2']")).Selected;
                ticket.SelectByIndex(2);
                IWebElement email = driver.FindElement(By.Id("dlslot_email"));
                email.SendKeys("fangm001@gmail.com");
                IWebElement month = driver.FindElement(By.Id("dlslot_dob_month"));
                month.SendKeys("05");
                IWebElement day = driver.FindElement(By.Id("dlslot_dob_day"));
                day.SendKeys("25");
                IWebElement year = driver.FindElement(By.Id("dlslot_dob_year"));
                year.SendKeys("1972");
                IWebElement zip = driver.FindElement(By.Id("dlslot_zip"));
                zip.SendKeys("60091");
                // click() doesn't work have to use sendkeys
                //driver.FindElement(By.Id("dlslot_agree")).Click();
                driver.FindElement(By.Id("dlslot_agree")).SendKeys(Keys.Space);
                //driver.Close();
                //driver.SwitchTo().Window(currentHandle);
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void HamiltonJing()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://lottery.broadwaydirect.com/show/hamilton-chicago/");
            string currentHandle = driver.CurrentWindowHandle;

            IWebElement enterNow = driver.FindElement(By.LinkText("Enter Now"));
            
            if (enterNow != null)
            {
               string href = enterNow.GetAttribute("href");
                driver.Navigate().GoToUrl(href);
                IWebElement firstName = driver.FindElement(By.Id("dlslot_name_first"));
                firstName.SendKeys("Jing");
                IWebElement lastName = driver.FindElement(By.Id("dlslot_name_last"));
                lastName.SendKeys("Zhang");
                SelectElement ticket = new SelectElement(driver.FindElement(By.Id("dlslot_ticket_qty")));
               ticket.SelectByIndex(2);
                IWebElement email = driver.FindElement(By.Id("dlslot_email"));
                email.SendKeys("zhangj001@yahoo.com");
                IWebElement month = driver.FindElement(By.Id("dlslot_dob_month"));
                month.SendKeys("05");
                IWebElement day = driver.FindElement(By.Id("dlslot_dob_day"));
                day.SendKeys("24");
                IWebElement year = driver.FindElement(By.Id("dlslot_dob_year"));
                year.SendKeys("1974");
                IWebElement zip = driver.FindElement(By.Id("dlslot_zip"));
                zip.SendKeys("60091");
                driver.FindElement(By.Id("dlslot_agree")).SendKeys(Keys.Space);
                //IWebElement agree = driver.FindElement(By.Id("dlslot_agree"));
                //agree.Click();
               Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
