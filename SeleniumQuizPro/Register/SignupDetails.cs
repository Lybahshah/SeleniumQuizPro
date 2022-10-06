using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuizPro
{
    public class SignupDetails:BasePage
    {
        By radioBtn = By.Id("id_gender2");
        By password=By.Id("password");
        By Date=By.Id("days");
        By Month = By.Id("months");
        By year = By.Id("years");
        By news = By.Id("newsletter");
        By offers = By.Id("optin");
        By fname = By.Id("first_name");
        By lname = By.Id("last_name");
        By add1 = By.Id("address1");
        By coun = By.XPath("//*[@id='country']");
        By state=By.Id("state");
        By city = By.Id("city");
        By zip = By.Id("zipcode");
        By contact = By.Id("mobile_number");
        By reg = By.XPath("//*[@id='form']/div/div/div/div[1]/form/button");

           public void Clickradio()
        {
            driver.FindElement(radioBtn).Click();
        }
        public void enterpass(string pass)
        {
            driver.FindElement(password).SendKeys(pass);
        }
        public void slctday()
        {
            var el=driver.FindElement(Date);
            var selectdropdown = new SelectElement(el);
            selectdropdown.SelectByValue("27");
            
        }
        public void slctmonth()
        {
            var ele = driver.FindElement(Month);
            var selectMonth = new SelectElement(ele);
            selectMonth.SelectByValue("7");
        }
        public void slctyear()
        {
            var elem = driver.FindElement(year);
            var selectMonth = new SelectElement(elem);
            selectMonth.SelectByValue("1995");
        }
        public void checknewsLetter()
        {
            driver.FindElement(news).Click();
        }
        public void checkoffers()
        {
            driver.FindElement(offers).Click(); 
        }
        public void firstname(string Fname)
        {
            driver.FindElement(fname).SendKeys(Fname);

        }
        public void lastname(string lName)
        {
            driver.FindElement(lname).SendKeys(lName);
        }
        public void enteradd(string ad)
        {
            driver.FindElement(add1).SendKeys(ad);

        }
        public void slctCountry()
        {
            var element = driver.FindElement(coun);
            var selectcountry = new SelectElement(element);
            selectcountry.SelectByValue("United States");

        }
        public void enterstate(string State)
        {
            driver.FindElement(state).SendKeys(State);
        }
        public void enterCity(string City)
        {
            driver.FindElement(city).SendKeys(City);
        }
        public void enterZip(string n)
        {
            driver.FindElement(zip).SendKeys(n);
        }
        public void enternum(string con)
        {
            driver.FindElement(contact).SendKeys(con);

        }

        public void clickreg()
        { 
           IWebElement elm= driver.FindElement(reg);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();",elm);
            elm.Click();
        }
        
    }
}

