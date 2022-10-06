using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuizPro
{
    public class Signup:BasePage
    {
        By SignupFeature = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        By RegName = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[2]");
        By RegEmail = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[3]");
        By SbmtBtn = By.XPath("//*[@id='form']/div/div/div[3]/div/form/button");

        public void ClickSignupFeature()
        {
            driver.FindElement(SignupFeature).Click();
        }
        public void EnterRegName(string name)
        {
            driver.FindElement(RegName).SendKeys(name);
        }
        public void EnterRegEmail(string email)
        {
            driver.FindElement(RegEmail).SendKeys(email);
        }
        public void ClickSbmtBtn()
        {

            driver.FindElement(SbmtBtn).Click();
        }
        
    }
}
