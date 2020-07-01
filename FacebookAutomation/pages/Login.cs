using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using FacebookAutomation.config;

namespace FacebookAutomation.pages
{
    class Login
    {
            IWebDriver driver;
            public Login(IWebDriver driver)
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }

            [FindsBy(How = How.Id, Using = "email")]
            public IWebElement EmailTextbox;
            [FindsBy(How = How.Id, Using = "pass")]
            public IWebElement PassTextbox;
            [FindsBy(How = How.XPath, Using = "//*[@id='u_0_b']")]
            public IWebElement LoginButton;

            public void HomePage()
            {
                Credentials cred = new Credentials();

                EmailTextbox.SendKeys(cred.email);
                PassTextbox.SendKeys(cred.password);
                LoginButton.Click();
                Thread.Sleep(5000);

            }
        }
    }
