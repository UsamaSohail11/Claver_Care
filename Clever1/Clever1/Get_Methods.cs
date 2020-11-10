using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clever1
{
    class Get_Methods
    {
        public static string Get_Text( string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
            {
              return  Web_Driver.driver.FindElement(By.XPath(value)).GetAttribute("value");
              
            }
            if (elementtype == PropertyType.Name)
            {
                return Web_Driver.driver.FindElement(By.XPath(value)).GetAttribute("value");

            }
            if (elementtype == PropertyType.Xpath)
            {
                return Web_Driver.driver.FindElement(By.XPath(value)).GetAttribute("value");

            }
            else
            {
                return String.Empty;
            }
        }
        public static void Click(string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
            {

            }
            if (elementtype == PropertyType.Name)
            {

            }
            if (elementtype == PropertyType.Xpath)
            {

            }
        }
    }
}
