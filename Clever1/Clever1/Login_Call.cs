using System;
using System.Collections.Generic;
using System.Text;

namespace Clever1
{
    class Login_Call
    {
        public static void Login_page_Invalid()
        {

            Log_In page = new Log_In();
            page.Log_Invalids("ali.ahsan@speridian.com", "P@sswrd");
            EA_POM next = new EA_POM();
        }
        public static void Login_page_valid()
        {

            Log_In page = new Log_In();
            page.Log_Valids("ali.ahsan@speridian.com", "P@ssw0rd");
            EA_POM next = new EA_POM();
        }
    }
}
