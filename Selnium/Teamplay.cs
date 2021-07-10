using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Selnium
{
   public class Teamplay
    {
        public static void LaunchTeamplay(IWebDriver webDriver) 
        {   
            webDriver.Url = "https://webclient-sandbox.test.teamplay.siemens.com/#/home";
            webDriver.Manage().Window.Maximize();
        }
        public static void LoginTeamplay(IWebDriver webDriver)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            ElementSubmit(webDriver, "email", "Sujay.kr@siemens-healthineers.com");
            ElementSubmit(webDriver, "password", "Raghu@56");
            ElementClick(webDriver, "btn-login");
        }
        public static void SelectInstitute(IWebDriver webDriver)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ElementClick(webDriver, "institution-identifier");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ElementClick(webDriver, "institutionRow1106");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ElementClick(webDriver, "appLauncherLaunchIcon");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ElementClick(webDriver, "hccloud.sb.rc.main.acc3.cncty.app");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ElementClick(webDriver, "actionButton");
        }

        public static void SelectApp(IWebDriver webDriver)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement body = webDriver.FindElement(By.TagName("body"));
            body.SendKeys(Keys.Control + 't');
        }
        public static void ElementClick(IWebDriver webDriver, string elementID)
        {
            webDriver.FindElement(By.Id(elementID)).Click();
        }

        public static void ElementSubmit(IWebDriver webDriver, string elementID, string sendkeycontent)
        {
            webDriver.FindElement(By.Id(elementID)).SendKeys(sendkeycontent);
        }
    }
}
