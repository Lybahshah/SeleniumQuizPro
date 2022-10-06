using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuizPro
{
    public class Download:BasePage
    {
        By Invoice = By.XPath("//*[@id='form']/div/div/div/a");
        public void clinkInvoice()
        {
            driver.FindElement(Invoice).Click();
        }
    }
}
