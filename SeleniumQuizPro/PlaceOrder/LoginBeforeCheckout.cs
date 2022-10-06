using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace SeleniumQuizPro
{
    public class LoginBeforeCheckout:BasePage
    {
        By View = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[2]/div/div[2]/ul/li/a");
        By Addto = By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/span/button");
        By Mod = By.XPath("//*[@id='cartModal']/div/div/div[3]/button");
        By Cart=By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[3]/a");
        By Pro = By.XPath("//*[@id='do_action']/div[1]/div/div/a");
        By desc = By.XPath("//*[@id='ordermsg']/textarea");
        By Place = By.XPath("//*[@id='cart_items']/div/div[7]/a");
        By name = By.Name("name_on_card");
        By cardno = By.XPath("//*[@id='payment - form']/div[2]/div/input");
        By cvc = By.XPath("//*[@id='payment - form']/div[3]/div[1]/input");
        By year = By.XPath("//*[@id='payment - form']/div[3]/div[3]/input");
        By submit = By.XPath("//*[@id='submit']");


        public void ViewCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           
            IWebElement elm = driver.FindElement(View);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", elm);
            wait.Until(ExpectedConditions.ElementToBeClickable(View)).Click();

            //driver.FindElement(View).Click();
        }
        public void AddToCart()
        {
            driver.FindElement(Addto).Click();
        }
        public void Modal()
        {
            
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(Mod)).Click();


        }
        public void CART()
        {
            driver.FindElement(Cart).Click();
        }
        public void produ()
        {
            driver.FindElement(Pro).Click();

        }
        public void Description(string describe)
        {
            driver.FindElement(desc).SendKeys(describe);

        }
        public void plceorder()
        {
            driver.FindElement(Place).Click();
        }
        public void CardName(string cardd)
        {
            driver.FindElement(name).SendKeys(cardd);
        }
        public void cardnum(string cardnumb)
        {
            driver.FindElement(cardno).SendKeys(cardnumb);

        }
        public void Entercvc(string cv)
        {
            driver.FindElement(cvc).SendKeys(cv);

        }
        public void enterex(string yr)
        {
            driver.FindElement(year).SendKeys(yr);
        }
        public void clicksbmt()
        {
            driver.FindElement(submit).Click();
        }
    }
}
