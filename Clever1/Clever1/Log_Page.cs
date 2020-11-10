using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace Clever1
{
    class Log_In
    {
        public Log_In()
       {

            PageFactory.InitElements(Web_Driver.driver, this);


        }
        public static string Title_Logpage;
        public static string Title_Homepage;
        public static string Url_Logpage;
        public static string Url_Homepage;
        public static string Invalid_Text;
        public static string Log_Text;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname='username']")]
        public IWebElement UserName { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname='password']")]

        public IWebElement Pasword { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@id='UserDropdown']")]
        public IWebElement Log_Out_Text { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IWebElement Click { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']")]
        public IWebElement Invalid_txt { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='profile-text']")]
        public IWebElement Log_Txt { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='dropdown-menu dropdown-menu-right navbar-dropdown show']")]
        public IWebElement Log_Out { get; set; }

        public EA_POM Log_Invalids(string user,string pass)
        {
            Url_Logpage = Web_Driver.driver.Url;
            Console.WriteLine(Url_Logpage);
            //User name and Password
            UserName.SendKeys(user);
            Pasword.SendKeys(pass);
            Title_Logpage = Web_Driver.driver.Title;
          
            Console.WriteLine(Title_Logpage);
           //Clicking on login 
            Click.Click();
            UserName.Clear();
            Pasword.Clear();
            Thread.Sleep(3000);
            //Getting text2
            Invalid_Text = Invalid_txt.Text;


            Title_Homepage = Web_Driver.driver.Title;
            Url_Homepage = Web_Driver.driver.Url;
            Console.WriteLine(Title_Homepage);
            Console.WriteLine(Url_Homepage);
            Asserts.Log_Invalid_Text(Invalid_Text);

            Asserts.Log_Invalid_Assert_Title(Title_Logpage,Title_Homepage);
            Asserts.Log_Invalid_Text(Invalid_Text);
            return new EA_POM();
        }
        public EA_POM Log_Valids(string user, string pass)
        {
            Url_Logpage = Web_Driver.driver.Url;
            Console.WriteLine(Url_Logpage);
            //User name and Password
            UserName.SendKeys(user);
            Pasword.SendKeys(pass);
            Title_Logpage = Web_Driver.driver.Title;

            Console.WriteLine(Title_Logpage);
            //Clicking on login 
            Click.Click();
            //  Thread.Sleep(3000);
            //Getting text2


            // Thread.Sleep(10000);
            Web_Driver.driver.Navigate();
            Web_Driver.ngWebDriver.WaitForAngular();
            Title_Homepage = Web_Driver.driver.Title;
         
            Url_Homepage = Web_Driver.driver.Url;
            Console.WriteLine(Title_Homepage);
            Console.WriteLine(Url_Homepage);
           
            Asserts.valid_Assert_Url(Url_Logpage,Url_Logpage);

            Asserts.Log_valid_Assert_Title(Title_Logpage, Title_Homepage);
            //Getting Log_Text
           Log_Text =Log_Txt.Text;
           Asserts.Assert_Log_Text(Log_Text);
            Text_Heightlight.highlight6(Log_Out_Text);
           //Logging out
            Log_Txt.Click();
            Thread.Sleep(4000);

            Log_Out.Click();
            Asserts.valid_Assert_logout_Url(Url_Homepage,Url_Logpage);
            Console.WriteLine(Log_Text);
            //Loging in for testing other pages
            UserName.SendKeys(user);
            Pasword.SendKeys(pass);
            //Clicking on login 
            Click.Click();
           
            return new EA_POM();
        }
       


    }
}
