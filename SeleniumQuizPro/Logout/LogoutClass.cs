using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuizPro
{
    public class LogoutClass:BasePage
    {
        By logoutfeat = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
       
        public void logoutuser()
        {
            driver.FindElement(logoutfeat).Click();
        }
    }
}
