using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuizPro
{
    public class Login:BasePage
    {
        By LoginFeature = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        By Email = By.XPath("//*[@id='form']/div/div/div[1]/div/form/input[2]");
        By passwrd = By.XPath("//*[@id='form']/div/div/div[1]/div/form/input[3]");
        By LoginBtn = By.XPath("//*[@id='form']/div/div/div[1]/div/form/button");

        public void ClickLogin()
        {
            driver.FindElement(LoginFeature).Click();
        }
        public void EnterEmail(string EMAIL)
        {
            driver.FindElement(Email).SendKeys(EMAIL);

        }
        public void EnterPassword(string pass)
        {
            driver.FindElement(passwrd).SendKeys(pass);
        }
        public void ClickLoginBtn()
        {
            driver.FindElement(LoginBtn).Click();
        }
        
    }
}
