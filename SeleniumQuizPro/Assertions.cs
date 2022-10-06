using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuizPro
{
    [TestClass]
    public class Assertions:BasePage
    {
       

        
            public void aSSERTaCCOUNTcREATION()
        {
            string exp = "ACCOUNT CREATED!";
            string act = driver.FindElement(By.XPath("//*[@id='form']/div/div/div/h2")).Text;
            Assert.AreEqual(exp, act);

        }
        public void assertUsernameIsVisible()
        {
            string expe ="Delete Account";
            string actual = driver.FindElement(By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[5]/a")).Text;
            Assert.AreEqual(expe, actual);
        }
        public void assertlogout()
        {
            string exp = "Login to your account";
            string act = driver.FindElement(By.XPath("//*[@id='form']/div/div/div[1]/div/h2")).Text;
            Assert.AreEqual(exp , act);
        }
    }
}
