using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace CreateGmailAccount
{
    class CreateGmail
    {
        //I web stuff
        static IWebDriver driver = new ChromeDriver();
        static IWebElement createGMail;
        static IWebElement createAccBtn;
        static IWebElement firstName;
        static IWebElement lastName;
        static IWebElement userName;
        static IWebElement pssWrd;
        static IWebElement pssWrdConfirm;
        static IWebElement nextButton;
        static void Main()
        {
            //muh variables
            string emailUrl = "https://support.google.com/mail/";
            string firstBtn = "/html/body/div[2]/div/section/div/div/article/nav/section[1]/div/div/div[4]/a";
            string createAnAcc = "/html/body/div[2]/div/section/div/div[1]/article/section/div/div/div[1]/p[1]/a";
            string firstNameBox = "/html//input[@id='firstName']";
            string LastNameBox = "//*[@id=\"lastName\"]";
            string userNameBox = "//*[@id=\"username\"]";
            string passwordBox = "//*[@id=\"passwd\"]/div[1]/div/div[1]/input";
            string confirmpasswordBox = "#confirm-passwd > div.aCsJod.oJeWuf > div > div.Xb9hP > input";
            string passwords = "ch3ck0utL1n3";
            string nxtBtn = "//*[@id=\"accountDetailsNext\"]";

            // Creating the account            

            driver.Navigate().GoToUrl(emailUrl);
            Thread.Sleep(3000);

            createGMail = driver.FindElement(By.XPath(firstBtn));
            createGMail.Click();
            Thread.Sleep(3000);

            createAccBtn = driver.FindElement(By.XPath(createAnAcc));
            createAccBtn.Click();
            Thread.Sleep(3000);

            var browserTabs = driver.WindowHandles;
            driver.SwitchTo().Window(browserTabs[1]);

            firstName = driver.FindElement(By.XPath(firstNameBox));
            firstName.SendKeys("Mr Test");
            
            lastName = driver.FindElement(By.XPath(LastNameBox));
            lastName.SendKeys("Man");

            userName = driver.FindElement(By.XPath(userNameBox));
            userName.SendKeys("sfgyterg5125612");
            
            pssWrd = driver.FindElement(By.XPath(passwordBox));
            pssWrd.SendKeys(passwords);

            pssWrdConfirm = driver.FindElement(By.CssSelector(confirmpasswordBox));
            pssWrdConfirm.SendKeys(passwords);
            Thread.Sleep(2000);

            nextButton = driver.FindElement(By.XPath(nxtBtn));
            nextButton.Click();

            Thread.Sleep(10000);



            driver.Quit();
        }
    }
}
