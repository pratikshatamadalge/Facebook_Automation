using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace FacebookAutomation.pages
{
    class AddPost
    {
        public AddPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div//div[contains(text(),\"What's on your mind, Pratiksha?\")]")]
        public IWebElement addPost;
         [FindsBy(How = How.XPath, Using = "//div[@class='rq0escxv datstx6m k4urcfbm a8c37x1j']//div[@class='_5rp7']//div[@class='_5rpb']//div[@class='notranslate _5rpu']//div//div//div[@class='_1mf _1mj']")]
        public IWebElement TextBox;
        [FindsBy(How = How.XPath, Using = "//i[@class='hu5pjgll bixrwtb6 sp_IkPyuveLqZD sx_9feb70']")]
        public IWebElement PhotoVideoButton; 
        //[FindsBy(How = How.XPath, Using = "//div[@class='_3-w4 _3-w6']")]
        //public IWebElement NewsFeedBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='oajrlxb2 s1i5eluu qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 pq6dq46d p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x cxgpxx05 d1544ag0 sj5x9vvc tw6a2znq oqcyycmt esuyzwwr f1sip0of lzcic4wl l9j0dhe7 abiwlrkh p8dawk7l ehryuci6 bp9cbjyn beltcj47 p86d2i9g aot14ch1 kzx2olss rt8b4zig n8ej3o3l agehan2d sk4xxmp2 lrazzd5p gigivrx4 sf5mxxl7 g0qnabr5 lrwzeq9o iqfcb0g7 lsqurvkf id6903cd jq4qci2q m5l1wtfr taijpn5t sn7ne77z oqhjfihn bwm1u5wc']")]
        public IWebElement PostButton;
        [FindsBy(How = How.Id, Using = "//div[@class='l9j0dhe7 j83agx80']//div[@class='oajrlxb2 tdjehn4e qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 j83agx80 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl l9j0dhe7 abiwlrkh p8dawk7l bp9cbjyn s45kfl79 emlxlaya bkmhp75w spb7xbtv rt8b4zig n8ej3o3l agehan2d sk4xxmp2 taijpn5t qypqp5cg q676j6op']")]
        public IWebElement DropdownBtn;
        [FindsBy(How = How.XPath, Using = "//div[@id='jsc_c_4p']//div[@class='j83agx80 cbu4d94t ew0dbk1b irj2b8pg']")]
        public IWebElement LogoutButton;


        public void UploadArticle()
        {

            addPost.Click();
            Thread.Sleep(3000);
            TextBox.SendKeys("Testing...");
            Thread.Sleep(4000);
            PhotoVideoButton.Click();
            Thread.Sleep(3000);
            Process.Start("F:\\AutoITFolder\\image.exe");
            Thread.Sleep(3000);
            PostButton.Click();
            Thread.Sleep(4000);
            //DropdownBtn.Click();
            //Thread.Sleep(5000);
            //LogoutButton.Click();
            Thread.Sleep(2000);
        }
    }
}