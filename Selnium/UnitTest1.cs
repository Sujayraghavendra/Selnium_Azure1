using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;

namespace Selnium
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver chrome = new ChromeDriver();

        [TestMethod]
        public void TeamplayLoginAndAppLaunch()
        {
            Teamplay.LaunchTeamplay(chrome);
            Teamplay.LoginTeamplay(chrome);
            
        }  

    }
}
