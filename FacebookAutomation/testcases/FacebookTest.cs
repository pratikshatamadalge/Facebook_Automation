using FacebookAutomation.pages;
using FacebookAutomation.BaseClass;
using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FacebookAutomation.testcases
{
    [TestFixture]
    class FacebookTest:Base
    {
            [Test, Order(0)]
            public void LoginTest()
            {
            Console.Out.Write("In Login test");
                Login login = new Login(driver);
                login.HomePage();

                string expectedPageTitle = "Facebook";
                string actualPageTitle = driver.Title;
                Console.WriteLine("Expected Title is:" + expectedPageTitle);
                Console.WriteLine("Actual Title is:" + actualPageTitle);
                Assert.AreEqual(expectedPageTitle, actualPageTitle);
            }

            [Test, Order(1)]
            public void AddPostTest()
            {
                AddPost article = new AddPost(driver);
                article.UploadArticle();
               // Assert.IsTrue(driver.FindElement(By.XPath("//img[@class='_s0 _4ooo _1x2_ _1ve7 _1gax img']")).Displayed);
            }

        }
    }

