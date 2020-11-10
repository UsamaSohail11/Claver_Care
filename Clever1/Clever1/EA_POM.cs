
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace Clever1
{
    class EA_POM
    {
        public EA_POM()
        {

           PageFactory.InitElements(Web_Driver.driver, this);
          

        }
       

    }
}
