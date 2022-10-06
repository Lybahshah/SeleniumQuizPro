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
    public class Execution
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            set
            {
                testContextInstance = value;
            }
            get { return testContextInstance; }

        }
        //Classes objects are created here
        BasePage basePage=new BasePage();
        Signup signup = new Signup();
        SignupDetails sd=new SignupDetails();
        Assertions asser = new Assertions();
        Login login = new Login();
        LogoutClass logout=new LogoutClass();
        LoginBeforeCheckout lo = new LoginBeforeCheckout();
        Download download = new Download();
        Execution ex=new Execution();



        //SignUp1
        [TestMethod]
        public void SignupAsNewUser()
        {
            basePage.SeleniumInit();
            string NAME = "Laiba";
            string Email = "laibariaz0@gmail.com";

            signup.ClickSignupFeature();
            signup.EnterRegName(NAME);
            signup.EnterRegEmail(Email);
            basePage.Screenshot();
           
            signup.ClickSbmtBtn();
            //basePage.DriverClose();
            string passwrd = "alidaan12";
            string first = "Laiba";
            string second = "Riaz";
            string Add = "Ashraf Garden,5566,city,aj";
            string STATE = "Punjab";
            string cit = "Raiwind";
            string zipcode = "6650";
            string Phone = "+923216666868";
            sd.Clickradio();
            sd.enterpass(passwrd);
            sd.slctday();
            sd.slctmonth();
            sd.slctyear();
            sd.checknewsLetter();
            sd.checkoffers();
            sd.firstname(first);
            sd.lastname(second);
            sd.enteradd(Add);
            sd.slctCountry();
            sd.enterstate(STATE);
            sd.enterCity(cit);
            sd.enterZip(zipcode);
            sd.enternum(Phone);
            basePage.Screenshot();
            sd.clickreg();
            asser.aSSERTaCCOUNTcREATION();
            basePage.DriverClose();

        }
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.XML", "Pro.xml", "Login", DataAccessMethod.Sequential)]
        [TestMethod]
        public void LoginViaCorrectEmailandCorrectPassword( )
        {

            string mail= TestContext.DataRow["user"].ToString();
            string Password = TestContext.DataRow["pass"].ToString();
          
            basePage.SeleniumInit();
            login.ClickLogin();
            login.EnterEmail(mail); 
            login.EnterPassword(Password);
            login.ClickLoginBtn();
          
            asser.assertUsernameIsVisible();
           
               
        }
        //[DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.XML", "Pro.xml", "Login", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Logout()
        {
            string mail = "laibariaz43@gmail.com";
            string Password = "alidaan12";
            basePage.SeleniumInit();
            login.ClickLogin();
            login.EnterEmail(mail);
            login.EnterPassword(Password);
            login.ClickLoginBtn();

            asser.assertUsernameIsVisible();

            logout.logoutuser();
        }
        //[DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.XML", "Pro.xml", "Login", DataAccessMethod.Sequential)]
        [TestMethod]
        public void LoginBeforeCheckout()
        {
            //LoginViaCorrectEmailandCorrectPassword();
            string decs = "hi,this is text";
            string cardn = "ubl";
            string cardnumber = "122039934e048";
            string cvc = "221";
            string year = "2024";
            

           
            lo.ViewCart();
            lo.AddToCart();
            lo.Modal();
            lo.CART();
            lo.produ();
            lo.Description(decs);
            lo.plceorder();
            lo.CardName(cardn);
            lo.cardnum(cardnumber);
            lo.Entercvc(cvc);
            lo.enterex(year);
            lo.clicksbmt();
        }
        [TestMethod]
        public void DownloadInvoice()
        {
            LoginBeforeCheckout();
            download.clinkInvoice();
        }
        
    }
}
