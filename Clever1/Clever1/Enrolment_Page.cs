using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;
namespace Clever1
{
    class Enrolment_Page
    {
        public Enrolment_Page()
        {

            PageFactory.InitElements(Web_Driver.driver, this);


        }
        public static string Pre_Id;
        public static string Up_Id;
        public static string Url_En_page;
        public static string Url_Creat_En_page;
        public static string Del_Record_Text;
        public static string Del_Record_No_Text;
        public static string Del_Record_Yes_Text;
        public static int Previous_Id;
        public static int New_Id;
        public static string txt_Id;
        public static string Created_Latest_Date;
        public static string Created_Last_Date;
        public static bool radio = false;
        public static int Previous_ID;
        public static int Updated_ID;
        public static bool checkbox = false;
        public static bool radio_1 = false;
        public static bool radio_2 = false;
        public static bool premium = false;
        public static bool Section_2_checked = false;
        public static bool Section_2_checked1 = false;
        public static bool Search_btn_bool = false;
        public static bool Id_Bool = false;
        public static bool Clear_Bool = false;
        public static bool Search_btn1_bool = false;
        public static bool Search_btn2_bool = false;
        public static bool Search_btn3_bool = false;
        public static bool Search_btn4_bool = false;
        public static string Save_Draft_Btn_Color;
        public static string Save_Draft_Btn_Color1;
        public static string Enroment_create_page_Url;
        public static string Enroment_Search_page_Url;
        public static string Plan_Edit_strng;
        public static string Name_strng;
        public static string Hphone_strng;
        public static string P_Address_strng;
        public static string P_Address_strng1;
        public static string P_City_Strng;
        public static string P_City_Strng1;
        public static string Email_Strng;
        public static string Email_Strng1;
        public static string P_State_Strng;
        public static string P_State_Strng1;
        public static string P_Zip_Strng;
        public static string P_Zip_Strng1;
        public static string P_County_Strng;
        public static string P_County_Strng1;
        public static string Hpnone1_strng;
        public static string Name_strng1;
        public static string LName_strng;
        public static string LName_strng1;
        public static string MName_strng;
        public static string MName_strng1;
        public static string male_radio;
        public static string Fee_Male_radio;
        public static string Dob_strng;
        public static string Dob_strng1;
        public static string Md_No_strng1;
        public static string Md_No_strng;
        public static bool Paylist_bool1;
        public static bool Paylist_bool2;
        public static bool Paylist_bool3;
        public static bool Clear_Btn1 = false;
        public static bool[] Total_En_App = new bool[3];
        public static bool Clear_Btn2 = false;
        public static bool Clear_Btn3 = false;
        public static bool Clear_Btn4 = false;
        public static bool Clear_Bool_1 = false;
        public static bool Clear_Bool_2 = false;
        public static bool Clear_Bool_3 = false;
        public static bool Clear_Bool_4 = false;
        public static bool[] Double_click = new bool[5];
        public static string[] Total_En_Appointment;
        public static string Edit_Record_Previous;
        public static string Edit_Record_Updated;
        public static string Edit_Id;
        [FindsBy(How = How.XPath, Using = "//a[@routerlink='/pages/enrollments']")]
        public IWebElement En_Tab_Click { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='click viewSigned ng-star-inserted']")]
        public IWebElement En_Del_Click { get; set; }
        [FindsBy(How = How.XPath, Using = "//form[@class='ng-untouched ng-pristine ng-valid']//div[@class='form-group']//p")]
        public IWebElement Del_Record_txt { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IWebElement No_Click { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-danger']")]
        public IWebElement Yes_Click { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr[1]//td[2]")]
        public IWebElement Del_Id { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@routerlink='/pages/enrollment']")]
        public IWebElement Create_En_btn { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Plan']")]
        public IList<IWebElement> Plan_Radio_btn { get; set; }
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement Name { get; set; }
        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement LName { get; set; }
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement MName { get; set; }
        [FindsBy(How = How.Name, Using = "DateOfBirth")]
        public IWebElement Dob { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Gender']")]
        public IList<IWebElement> Radio_M_F { get; set; }
        [FindsBy(How = How.Name, Using = "HomePhone")]
        public IWebElement Hphone { get; set; }
        [FindsBy(How = How.Name, Using = "PermanentAddress")]
        public IWebElement P_Address { get; set; }
        [FindsBy(How = How.Name, Using = "PermanentCity")]
        public IWebElement P_City { get; set; }
        [FindsBy(How = How.Name, Using = "PermanentCounty")]
        public IWebElement P_County { get; set; }
        [FindsBy(How = How.Name, Using = "PermanentState")]
        public IWebElement P_State { get; set; }
        [FindsBy(How = How.Name, Using = "PermanentZipCode")]
        public IWebElement P_Zip { get; set; }
        [FindsBy(How = How.Name, Using = "IsMailingAddressDifferent")]
        public IWebElement Mailing_Adress { get; set; }
        [FindsBy(How = How.Name, Using = "MailingAddress")]
        public IWebElement Street_Adress { get; set; }
        [FindsBy(How = How.Name, Using = "MailingCity")]
        public IWebElement Mailing_City { get; set; }
        [FindsBy(How = How.Name, Using = "MailingState")]
        public IWebElement Mailing_State { get; set; }
        [FindsBy(How = How.Name, Using = "MailingZipCode")]
        public IWebElement Mailing_Zip { get; set; }
        [FindsBy(How = How.Name, Using = "MediCareNumber")]
        public IWebElement MD_Number { get; set; }
        [FindsBy(How = How.Name, Using = "AttorneyName")]
        public IWebElement AttorneyName { get; set; }
        [FindsBy(How = How.Name, Using = "AttorneyAddress")]
        public IWebElement AttorneyAddress { get; set; }
        [FindsBy(How = How.Name, Using = "AttorneyPhone")]
        public IWebElement AttorneyPhone { get; set; }
        [FindsBy(How = How.Name, Using = "AttorneyRelation")]
        public IWebElement Attorneyrelation { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-md-12']//input")]
        public IList<IWebElement> Section_2_Checkbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-md-6']//div[@class='col-md-3 col-sm-12']//input")]
        public IList<IWebElement> Section_2_Checkbox2 { get; set; }
        [FindsBy(How = How.Name, Using = "EmailAddress")]
        IWebElement Email_Adress { get; set; }
        [FindsBy(How = How.Name, Using = "IsRRBBenefit")]
        IWebElement Premium_check { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Attestation']")]
        public IList<IWebElement> Attestation { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-toggle filter-link ng-star-inserted']")]
        public IList<IWebElement> Hash_Drop { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='searchInput']")]
        public IList<IWebElement> Search_Records { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr")]
        public IList<IWebElement> Search_Record_Results { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-sm btn-primary']")]
        public IList<IWebElement> Search_btn { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-sm btn-secondary']")]
        public IList<IWebElement> Clear_Btn { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr[1]//td[6]")]
        public IWebElement Created_Date { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='filter-link ng-star-inserted'][text()=' Created On ']")]
        public IWebElement Created_Click { get; set; }
        [FindsBy(How = How.XPath, Using = "//h3[@class='font-weight-medium mb-0']")]
        public IList<IWebElement> Total_Appointment_En { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='row']")]
        public IList<IWebElement> Total_Appointment_En_Highlight_Text { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr[1]//td[1]")]
        public IWebElement Edit_En_btn { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@value='H7607-003-001']")]
        public IWebElement Plan_Edit_Btn { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table-responsive table-bordered']//tbody//tr[10]//td[2]")]
        public IWebElement Plan_Edit_Text { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='IsPaymentByMail'] | //input[@name='IsPaymentByEFT'] |  //input[@name='IsRRBBenefit']")]
        public IList<IWebElement> Paylist { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary m-1']")]
        public IList<IWebElement> SaveDraft { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr[1]")]
        public IWebElement Edit_Record { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr[1]//td[2]")]
        public IWebElement Search_Record_Colums { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr//td[2]")]
        public IList<IWebElement> Search_Record_Results1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr//td[3]")]
        public IList<IWebElement> Search_Record_Results2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr//td[4]")]
        public IList<IWebElement> Search_Record_Results3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr//td[5]")]
        public IList<IWebElement> Search_Record_Results4 { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary m-1']")]
        public IList<IWebElement> Genrete_Enrolment { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IList<IWebElement> Genrete_Enrolment_Yes_Btn { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr[1]")]
        public IWebElement Delete_Record_Text { get; set; }
        [FindsBy(How = How.XPath, Using = "//td[@class='font-weight-medium']")]
        public IList<IWebElement> Previous_ID_txt { get; set; }
        [FindsBy(How = How.XPath, Using = "//td[@class='font-weight-medium']")]
        public IList<IWebElement> Created_ID_txt { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IList<IWebElement> Genrete_Appoinment_Ok_Btn { get; set; }
        public EA_POM Delete_Enrolment()


        {

            //Clicking on Enrolment Tab
            Web_Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            if (All_Calls.Delete_Enrolment_On == true)
            {
                En_Tab_Click.Click();
            }
            Thread.Sleep(3000);
            Url_En_page = Web_Driver.driver.Url;
            //Delete Enrolment
            Text_Heightlight.highlight7(Delete_Record_Text);
            En_Del_Click.Click();
            txt_Id = Del_Id.Text;
            int.TryParse(txt_Id, out Previous_Id);
            Console.WriteLine(Previous_Id);
            //Getting Record form text

            Del_Record_Text = Del_Record_txt.Text;
            Console.WriteLine(Del_Record_Text);
            Asserts.Assert_Del_Record_Text(Del_Record_Text);
            Thread.Sleep(3000);
            //Delete Yes,No
            Del_Record_No_Text = No_Click.Text;
            Asserts.Assert_Del_No(Del_Record_No_Text);
            Thread.Sleep(3000);
            No_Click.Click();


            //Delete Enrolment
            En_Del_Click.Click();
            //Delete Yes,No
            Del_Record_Yes_Text = Yes_Click.Text;
            Asserts.Assert_Del_Yes(Del_Record_Yes_Text);
            Yes_Click.Click();
            //Getting new Id
            Thread.Sleep(5000);
            txt_Id = Del_Id.Text;
            int.TryParse(txt_Id, out New_Id);
            Text_Heightlight.highlight7(Delete_Record_Text);
            Console.WriteLine(New_Id);
            Console.WriteLine(Log_In.Url_Homepage);
            Console.WriteLine(Url_En_page);
            Asserts.Enrolment_Page_Url(Log_In.Url_Homepage, Url_En_page);
            Asserts.Delete_Id_Comparison(Previous_Id, New_Id);
            return new EA_POM();
        }
        public Random rand = new Random();
        public EA_POM Create_Enrolment()
        {
            Thread.Sleep(3000);
            //   string[] vals = new string[] { "H7607-002-001", "H7607-002-002", "H7607-002-003", "H7607-003-001", "H7607-003-002", "H7607-003-003" };
            En_Tab_Click.Click();
            Thread.Sleep(3000);
            Pre_Id = Previous_ID_txt.ElementAt(0).Text;
            int.TryParse(Pre_Id, out Previous_ID);
            Create_En_btn.Click();
            Url_Creat_En_page = Web_Driver.driver.Url;
            Asserts.Url_Create_En(Url_Creat_En_page, Url_En_page);
            Console.WriteLine(Url_Creat_En_page);
            Console.WriteLine(Url_En_page);
            //Plan radio button verifying 
            for (int i = 0; i < Plan_Radio_btn.Count; i++)
            {
                try
                {
                    Plan_Radio_btn.ElementAt(i).Click();
                    radio = Plan_Radio_btn.ElementAt(i).Selected;
                    if (radio = Plan_Radio_btn.ElementAt(i).Selected)
                    {
                        //  Console.WriteLine(Plan_Radio_btn.ElementAt(i).Selected + "Button  clicked");
                        Asserts.Assert_Radiobtn(radio);

                    }




                }
                catch
                {
                    Asserts.Assert_Radiobtn(false);
                }



            }
            // List<string> list = new List<string>();
            IList<IWebElement> rows = Web_Driver.driver.FindElements(By.XPath("//table[@class='table-responsive table-bordered']//tbody//tr"));
            for (int i = 3; i < 6; i++)
            {
                // Console.WriteLine(rows[i].Text);
                if (rows[i].Text == "H7607-002-001 Los Angeles" || rows[i].Text == "H7607-002-002 Orange" || rows[i].Text == "H7607-002-003 San Diego")
                {

                    // Console.WriteLine(rows[i].Text);
                    bool txtverified = true;
                    Asserts.Assert_Plans(txtverified);
                }
                else
                {
                    bool txtverified = false;
                    Asserts.Assert_Plans(txtverified);
                }
                for (int j = 7; j < 10; j++)
                {
                    //Console.WriteLine(rows[i].Text);
                    if (rows[j].Text == "H7607-003-001 Los Angeles" || rows[j].Text == "H7607-003-002 Orange" || rows[j].Text == "H7607-003-003 San Diego")
                    {

                        //  Console.WriteLine(rows[j].Text);
                        bool txtverified = true;
                        Asserts.Assert_Plans1(txtverified);
                    }
                    else
                    {
                        bool txtverified = false;
                        Asserts.Assert_Plans1(txtverified);
                    }

                }
            }



            //First name verified 
            Name.SendKeys("Usama");


            //Last name verified 
            LName.SendKeys("Sohail");


            //Middle name verified 

            MName.SendKeys("Puma");




            //Required Date Of Birth verified 
            Dob.SendKeys("05/07/2020");

            //Sex Male/FeeMale radio btns
            for (int i = 0; i < Radio_M_F.Count; i++)
            {
                try
                {
                    Radio_M_F.ElementAt(i).Click();
                    radio_1 = Radio_M_F.ElementAt(i).Selected;
                    if (radio_1 = Radio_M_F.ElementAt(i).Selected)
                    {
                        Console.WriteLine(Radio_M_F.ElementAt(i).Selected + "Button is  clicked");
                        Asserts.Assert_Radiobtn(radio_1);

                    }




                }
                catch
                {
                    Asserts.Assert_Radiobtn(false);
                }
            }
            /// Entring Home Phone
            Hphone.SendKeys("5672348791");
            //Entering Permanent Address
            P_Address.SendKeys("72 Health center");
            //Entering Permanent City
            P_City.SendKeys("Lahore");
            //Entering Permanent County
            P_County.SendKeys("Pak");
            //Entering Permanent State
            P_State.SendKeys("Pakistan");
            //Entering Permanent Zip
            P_Zip.SendKeys("315550");
            //Mailing Adress CheckBox
            Mailing_Adress.Click();
            checkbox = Mailing_Adress.Selected;
            if (checkbox == true)
            {
                Asserts.Mailing_Checkbox(true);
            }
            else
            {
                Asserts.Mailing_Checkbox(false);
            }

            //Entering data into street address input box

            Street_Adress.SendKeys("72 Health center street No 10");
            //Entering data into Mailing City

            Mailing_City.SendKeys("Faisalabad");
            //Entering data into Mailing State

            Mailing_State.SendKeys("England");
            //Entering data into Mailing Zipcode

            Mailing_Zip.SendKeys("4532678");
            //Entering data into MdNumber

            MD_Number.SendKeys("Md-9999");
            //Entering data into AttorneName
            AttorneyName.SendKeys("Gul");
            //Entering data into AttorneAdree
            AttorneyAddress.SendKeys("123 street near new clonoy 1");
            //Entering data into Attorny Phone
            AttorneyPhone.SendKeys("2324445787");
            //Entering data into Attorny Phone
            Attorneyrelation.SendKeys("Cousin");
            for (int i = 0; i < Section_2_Checkbox2.Count; i++)
            {
                try
                {
                    Section_2_Checkbox2.ElementAt(i).Click();
                    Section_2_checked1 = Section_2_Checkbox2.ElementAt(i).Selected;
                    if (Section_2_checked1 = Section_2_Checkbox2.ElementAt(i).Selected)
                    {
                        Console.WriteLine(Section_2_Checkbox2.ElementAt(i).Selected + "Section 2 Button not clicked");
                        Asserts.Section2_Checkbox(Section_2_checked1);

                    }




                }
                catch
                {
                    Asserts.Section2_Checkbox(false);
                }

                {

                }


            }
            for (int i = 0; i < Section_2_Checkbox.Count; i++)
            {
                try
                {
                    Section_2_Checkbox.ElementAt(i).Click();
                    Section_2_checked = Section_2_Checkbox.ElementAt(i).Selected;
                    if (Section_2_checked = Section_2_Checkbox.ElementAt(i).Selected)
                    {
                        Console.WriteLine(Section_2_Checkbox.ElementAt(i).Selected + "Button not clicked");
                        Asserts.Assert_Radiobtn(Section_2_checked);

                    }




                }
                catch
                {
                    Asserts.Assert_Radiobtn(false);
                }

                {

                }


            }
            //Entring email address
            Email_Adress.SendKeys("usama.sohail@Speridian.com");
            Premium_check.Click();
            premium = Premium_check.Selected;
            if (premium == true)
            {
                Asserts.Section2_Checkbox(true);
            }
            else
            {
                Asserts.Section2_Checkbox(false);
            }
            for (int i = 0; i < Attestation.Count; i++)
            {
                try
                {
                    Attestation.ElementAt(i).Click();
                    radio_2 = Attestation.ElementAt(i).Selected;
                    if (radio_2 == true)
                    {
                        Console.WriteLine(Attestation.ElementAt(i).Selected + "Attestation Radio Button  clicked");
                        Asserts.Assert_Radiobtn(radio_2);

                    }

                }
                catch
                {
                    Asserts.Assert_Radiobtn(false);
                }

                Genrete_Enrolment.ElementAt(1).Click();
                Web_Driver.ngWebDriver.WaitForAngular();
                Genrete_Enrolment_Yes_Btn.ElementAt(1).Click();
                Web_Driver.ngWebDriver.WaitForAngular();
                Genrete_Appoinment_Ok_Btn.ElementAt(1).Click();
                Web_Driver.ngWebDriver.WaitForAngular();
                Web_Driver.driver.Navigate().Refresh();
                Web_Driver.ngWebDriver.WaitForAngular();
                Up_Id = Created_ID_txt.ElementAt(0).Text;
                int.TryParse(Up_Id, out Updated_ID);
                Asserts.ID_Compare(Updated_ID, Previous_ID);
                Console.WriteLine(Previous_ID);
                Console.WriteLine(Updated_ID);

            }
            return new EA_POM();
        }
        public EA_POM Dash_Board()
        {
            Web_Driver.ngWebDriver.WaitForAngular();

            //  Web_Driver.driver.Navigate().Refresh();

            //Getting Total Appointment and Enrolment

            try
            {
                if(Total_Appointment_En.Count==0)
                {
                    Asserts.Total_Count(false);
                }
                 Text_Heightlight.highlight5(Total_Appointment_En_Highlight_Text.ElementAt(1));
                Text_Heightlight.highlight5(Total_Appointment_En_Highlight_Text.ElementAt(2));
                for (int i = 0; i < Total_Appointment_En.Count; i++)
                {
                  
                    Console.WriteLine(Total_Appointment_En.ElementAt(i).Text);

                    //  Total_En_Appointment[i] = Total_Appointment_En.ElementAt(i).Text;
                    //Total_En_App[i] = Total_Appointment_En.ElementAt(i).Displayed;


                    if (Total_Appointment_En.ElementAt(i).Text != null)
                    {
                        Asserts.Total_Count(true);
                    }


                  



                }

            }
            catch
            {
                Asserts.Total_Count(false);
            }
            

            return new EA_POM();
    }

        public EA_POM Search_Enrolment()
        {

            Thread.Sleep(2000);
            //Clicking on DropDown

            Hash_Drop.ElementAt(0).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            Search_Records.ElementAt(0).Click();
            //Passing data into Search box
            Search_Records.ElementAt(0).SendKeys("1741");
            try
            {
                //Clicking on Search btn 
                Search_btn.ElementAt(0).Click();
                //getting button Element
                Search_btn_bool = Search_btn.ElementAt(0).Displayed;
                Thread.Sleep(3000);
                //Search button verify
                if (Search_btn_bool == true)
                {
                    Asserts.Assert_Search_btn(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_btn(false);
            }
            //Verifying Search results
            for (int i = 0; i < Search_Record_Results.Count; i++)
            {
                Id_Bool = Search_Record_Results[i].Displayed;
                Console.WriteLine(Search_Record_Results[i].Text);
            }
            if (Id_Bool == true)
            {

                Asserts.Assert_Id_Found(true);
            }
            else
            {
                Asserts.Assert_Id_Found(false);
            }

            Thread.Sleep(3000);
            Double_click[0] = true;
            // Web_Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Double();
            //Clicking on Clear Button
            Thread.Sleep(3000);
            try
            {
                //Verifying Search_Clear button
                Clear_Btn.ElementAt(0).Click();
                Clear_Bool = Clear_Btn.ElementAt(0).Displayed;

                if (Clear_Bool == true)
                {
                    Asserts.Assert_Search_Clear(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_Clear(false);
            }
            //Disapear Drop
            Thread.Sleep(3000);
            Hash_Drop.ElementAt(0).Click();
            //Verifying Search With Name

            //Clicking on DropDown
            Hash_Drop.ElementAt(1).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            Search_Records.ElementAt(1).Click();
            //Passing data into Search box
            Search_Records.ElementAt(1).SendKeys("Usama");
            try
            {
                //Clicking on Search btn 
                Search_btn.ElementAt(1).Click();
                //getting button Element
                Search_btn1_bool = Search_btn.ElementAt(1).Displayed;
                Thread.Sleep(3000);
                //Search button verify
                if (Search_btn1_bool == true)
                {
                    Asserts.Assert_Search_btn(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_btn(false);
            }
            //Verifying Search results
            
            try
            {
                int i;
                bool[] Name_Bool = new bool[Search_Record_Results.Count];
                Console.WriteLine(Search_Record_Results.Count + "" +
                    " Records");
                for ( i =0; i < Search_Record_Results.Count; i++)
                {

                    Name_Bool[i] = Search_Record_Results[i].Displayed;
                    Console.WriteLine(Search_Record_Results[i].Text);
                    if (Name_Bool[i] == true)
                    {

                        Asserts.Assert_Name_Found(Name_Bool[i]);
                    }
                    
                }
                
                if (Search_Record_Results.Count ==0)
                {
                    Asserts.Assert_Name_Found(false);
                }
            }
            catch
            {
              
            }

            Thread.Sleep(3000);
            Double_click[1] = true;
            // Web_Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Double();
            //Clicking on Clear Button
            Thread.Sleep(3000);
            try
            {
                //Verifying Search_Clear button
                Clear_Btn.ElementAt(1).Click();
                Clear_Bool_1 = Clear_Btn.ElementAt(1).Displayed;

                if (Clear_Bool_1 == true)
                {
                    Asserts.Assert_Search_Clear(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_Clear(false);
            }
            //Disapear Drop
            Thread.Sleep(3000);
            Hash_Drop.ElementAt(1).Click();
            //Verifying email Address
            Hash_Drop.ElementAt(2).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            Search_Records.ElementAt(2).Click();
            //Passing data into Search box
            Search_Records.ElementAt(2).SendKeys("usama.sohail28@gmail.com");
            try
            {
                //Clicking on Search btn 
                Search_btn2_bool = Search_btn.ElementAt(2).Displayed;
                Search_btn.ElementAt(2).Click();
                //getting button Element
               
                Console.WriteLine(Search_btn2_bool);
                Thread.Sleep(3000);
                //Search button verify
                if (Search_btn2_bool == true)
                {
                    Asserts.Assert_Search_btn(true);
                }
                else
                {
                    Asserts.Assert_Search_btn(false);
                }
            }
            catch
            {

            }
            try
            {
                //Verifying Search results
                int i = 0;
                bool[] Email_Bool = new bool[Search_Record_Results.Count];
                for (i = 0; i < Search_Record_Results.Count; i++)
                {
                    Email_Bool[i] = Search_Record_Results[i].Displayed;
                    Console.WriteLine(Search_Record_Results[i].Text);
                    Console.WriteLine(Email_Bool+"  Email bool");
                    if (Email_Bool[i] == true)
                    {
                       
                        Asserts.Assert_Email_Found(Email_Bool[i]);
                    }
                }

                if (Search_Record_Results.Count == 0)
                {
                    Asserts.Assert_Email_Found(false);
                }
            }
            catch
            {
               
            }
            
         

            Thread.Sleep(3000);
            Double_click[2] = true;
            // Web_Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Double();
            //Clicking on Clear Button
            Thread.Sleep(3000);
            try
            {
                //Verifying Search_Clear button
                Clear_Btn.ElementAt(4).Click();
                Clear_Bool_2 = Clear_Btn.ElementAt(2).Displayed;

                if (Clear_Bool_2 == true)
                {
                    Asserts.Assert_Search_Clear(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_Clear(false);
            }
            //Disapear Drop
            Thread.Sleep(3000);
            Hash_Drop.ElementAt(2).Click();
            //Verifying Plan Records
            //Clicking on DropDown
            Hash_Drop.ElementAt(3).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            Search_Records.ElementAt(3).Click();
            //Passing data into Search box
            Search_Records.ElementAt(3).SendKeys("H7607-003-003");
            try
            {
                //Clicking on Search btn 
                Search_btn.ElementAt(3).Click();
                //getting button Element
                Search_btn3_bool = Search_btn.ElementAt(3).Displayed;
                Thread.Sleep(3000);
                //Search button verify
                if (Search_btn3_bool == true)
                {
                    Asserts.Assert_Search_btn(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_btn(false);
            }
            //Verifying Search results
            try
            {
                int i;
                bool[] Plan_Bool = new bool[Search_Record_Results.Count];
                for (i = 0; i < Search_Record_Results.Count; i++)
                {
                    Plan_Bool[i] = Search_Record_Results[20].Displayed;
                    Console.WriteLine(Search_Record_Results[i].Text);
                    if (Plan_Bool[i] == true)
                    {

                        Asserts.Assert_Plan_Found(Plan_Bool[i]);
                    }
                    
                    
                       
                    
                }
                if (Search_Record_Results.Count == 0)
                {
                    Asserts.Assert_Plan_Found(false);
                }
            }
            catch
            {
               
            }

            Thread.Sleep(3000);
            Double_click[3] = true;
            // Web_Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Double();
            //Clicking on Clear Button
            Thread.Sleep(3000);
            try
            {
                //Verifying Search_Clear button
                Clear_Btn.ElementAt(3).Click();
                Clear_Bool_3 = Clear_Btn.ElementAt(3).Displayed;
                Console.WriteLine(Clear_Bool_3);
              
               

                if (Clear_Bool_3 == true)
                {
                    Asserts.Assert_Search_Clear(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_Clear(false);
            }
            //Disapear Drop
            Thread.Sleep(3000);
            Hash_Drop.ElementAt(3).Click();

            //Verifying Created
            //Getting Latest date 
          Created_Latest_Date = Created_Date.Text;
            Console.WriteLine(Created_Latest_Date);
            Created_Click.Click();
            Thread.Sleep(3000);
            Created_Last_Date = Created_Date.Text;
            Console.WriteLine(Created_Last_Date);
            Asserts.Date_Comparison(Created_Latest_Date,Created_Last_Date);
            //Verifying Status 
            Hash_Drop.ElementAt(4).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            Search_Records.ElementAt(4).Click();
            //Passing data into Search box
            Search_Records.ElementAt(4).SendKeys("Draft");
            try
            {
                //Clicking on Search btn 
           
                Search_btn.ElementAt(5).Click();
                //getting button Element
                Search_btn4_bool = Search_btn.ElementAt(5).Displayed;
                Thread.Sleep(3000);
                //Search button verify
                if (Search_btn4_bool == true)
                {
                    Asserts.Assert_Search_btn(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_btn(false);
            }
            //Verifying Search results
            try
            {
                int i;
                bool[] Status_Bool = new bool[Search_Record_Results.Count];
                for (i = 67; i < Search_Record_Results.Count; i++)
                {
                    Status_Bool[i] = Search_Record_Results[i].Displayed;
                    Console.WriteLine(Search_Record_Results[i].Text);
                    if (Status_Bool[i] == true)
                    {

                        Asserts.Assert_Status_Found(Status_Bool[i]);
                    }
                }
                if (Search_Record_Results.Count == 0)
                {
                    Asserts.Assert_Status_Found(false);
                }
            }
            catch
            
            {
               
            }

            Thread.Sleep(3000);
            Double_click[4] = true;
            // Web_Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Double();
            //Clicking on Clear Button
            Thread.Sleep(3000);
            try
            {
                //Verifying Search_Clear button
                Clear_Btn.ElementAt(5).Click();
                Clear_Bool_4 = Clear_Btn.ElementAt(5).Displayed;

                if (Clear_Bool_4 == true)
                {
                    Asserts.Assert_Search_Clear(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_Clear(false);
            }
            //Disapear Drop
            Thread.Sleep(3000);
            Hash_Drop.ElementAt(4).Click();
            return new EA_POM();
        }
        public EA_POM Edit_Enrolment()
        {
           
           
           
            Web_Driver.ngWebDriver.WaitForAngular();
            //Getting Records
            Edit_Record_Previous = Edit_Record.Text;
            Console.WriteLine(Edit_Record_Previous + "Previous Record");
           Edit_Id= Search_Record_Colums.Text;
            Console.WriteLine(Edit_Id+"Id");
            Edit_En_btn.Click();
            Web_Driver.ngWebDriver.WaitForAngular();
          //  Plan_Edit_Btn.Click();
        //Getting Text of previous Fields
            Plan_Edit_strng =Plan_Edit_Text.Text;
            Console.WriteLine(Plan_Edit_strng);
            //Getting First Name
            Name_strng = Name.GetAttribute("value");
            Console.WriteLine(Name_strng);
            Name.Clear();
            Name.SendKeys("Ali");
            //Getting New Values
            Name_strng1 = Name.GetAttribute("value");
            Console.WriteLine(Name_strng1);
            //Getting Last Name
            LName_strng = LName.GetAttribute("value");
            Console.WriteLine(LName_strng);
            LName.Clear();
            LName.SendKeys("Asad");
            //Getting new Values 
            LName_strng1 = LName.GetAttribute("value");
            Console.WriteLine(LName_strng1);
            //Getting MidName
            MName_strng = MName.GetAttribute("value");
            Console.WriteLine(MName_strng);
            MName.Clear();
            MName.SendKeys("Asa");
            //Getting new Values
            MName_strng1 = MName.GetAttribute("value");
            Console.WriteLine(MName_strng1);
            //Getting Date of Birth
            Dob_strng = Dob.GetAttribute("value");
            Console.WriteLine(Dob_strng);
            Dob.Clear();
            Dob.SendKeys("10/11/2022");
            //Getting new Values
            Dob_strng1 = Dob.GetAttribute("value");
            Console.WriteLine(Dob_strng1);
            //Radio btn 
             male_radio = Radio_M_F.ElementAt(0).GetAttribute("value");
            Console.WriteLine(male_radio);
            Radio_M_F.ElementAt(1).Click();
            Fee_Male_radio = Radio_M_F.ElementAt(1).GetAttribute("value");
            Console.WriteLine(Fee_Male_radio);
            //Phone number 
            Hphone_strng = Hphone.GetAttribute("value");
            Console.WriteLine(Hphone_strng);
            Hphone.Clear();
            Hphone.SendKeys("9878564598");
            Hpnone1_strng = Hphone.GetAttribute("value");
            Console.WriteLine(Hpnone1_strng);
            //Permanent address
            P_Address_strng=P_Address.GetAttribute("value");
            Console.WriteLine(P_Address_strng);
            //New Values
            P_Address.Clear();
            P_Address.SendKeys("878# Street no5");
            P_Address_strng1= P_Address.GetAttribute("value");
            Console.WriteLine(P_Address_strng1);
            //Permanent City
            P_City_Strng = P_City.GetAttribute("value");
            Console.WriteLine(P_City_Strng);
            //New Values
            P_City.Clear();
            P_City.SendKeys("Karachi");
            P_City_Strng1 = P_City.GetAttribute("value");
            Console.WriteLine(P_City_Strng1);
            //Permanent County
            P_County_Strng = P_County.GetAttribute("value");
            Console.WriteLine(P_County_Strng);
            //New Values
            P_County.Clear();
            P_County.SendKeys("County");
            P_County_Strng1 = P_County.GetAttribute("value");
            Console.WriteLine(P_County_Strng1);
            //Permanent State
            P_State_Strng = P_State.GetAttribute("value");
            Console.WriteLine(P_State_Strng);
            //New Values
            P_State.Clear();
            P_State.SendKeys("USA");
            P_State_Strng1 = P_State.GetAttribute("value");
            Console.WriteLine(P_State_Strng1);
            //ZipCode
            P_Zip_Strng = P_Zip.GetAttribute("value");
            Console.WriteLine(P_Zip_Strng);
            //New Values
            P_Zip.Clear();
            P_Zip.SendKeys("453454");
            P_Zip_Strng1 = P_Zip.GetAttribute("value");
            Console.WriteLine(P_Zip_Strng1);
                 //MD_Number
            Md_No_strng = MD_Number.GetAttribute("value");
            Console.WriteLine(Md_No_strng);
            //New Values
            MD_Number.Clear();
            MD_Number.SendKeys("MD_9001");
            Md_No_strng1 = P_Zip.GetAttribute("value");
            Console.WriteLine(Md_No_strng1);
            //Email Address
            Email_Strng = Email_Adress.GetAttribute("value");
            Console.WriteLine(Email_Strng);
            //New Values
            Email_Adress.Clear();
            Email_Adress.SendKeys("Osama.Sohail@gmail.com");
            Email_Strng = Email_Adress.GetAttribute("value");
            Console.WriteLine(Email_Strng1);
            //Pay List testing unchecked CheckBox
          
           
            Paylist_bool1 =Paylist.ElementAt(0).Selected;
            Paylist_bool2 = Paylist.ElementAt(1).Selected;
            Paylist_bool3 = Paylist.ElementAt(2).Selected;
            if (Paylist_bool1 == true || Paylist_bool2 == true || Paylist_bool3 ==true)
            {
                if(Paylist_bool1 == true)
                {
                     Paylist.ElementAt(0).Click();
                }
                if (Paylist_bool2 == true)
                {
                    Paylist.ElementAt(1).Click();
                }
                if (Paylist_bool3 == true)
                {
                    Paylist.ElementAt(2).Click();
                }
                Asserts.Pay_list1(true);

            }

            if (Paylist_bool1==false&&Paylist_bool2==false&Paylist_bool3==false)
            {
                Asserts.Pay_list1(true);
              
            }
            //cliking on single paylist
            Paylist.ElementAt(0).Click();
            Paylist_bool1 = Paylist.ElementAt(0).Selected;
            Paylist_bool2 = Paylist.ElementAt(1).Selected;
            Paylist_bool3 = Paylist.ElementAt(2).Selected;
            if (Paylist_bool1 == true && Paylist_bool2 == false & Paylist_bool3 == false)
            {
                Asserts.Pay_list(Paylist_bool1);
               
            }
            else
            {
                Asserts.Pay_list(false);
            }
            //Asertion for Records inrequired fields are changed or not 
            if(Name_strng!=Name_strng1&&LName_strng!=LName_strng1&&MName_strng!=MName_strng1&&Dob_strng!=Dob_strng1&&P_Address_strng!=P_Address_strng1&&P_City_Strng!=P_City_Strng1&&P_State_Strng!=P_State_Strng1&&male_radio!=Fee_Male_radio&&Md_No_strng!=Md_No_strng1&&Email_Strng!=Email_Strng1)
            {
                Asserts.En_Search_Create_pages_Fields_Edit(true);
            }
            else
            {
                Asserts.En_Search_Create_pages_Fields_Edit(false);
            }
            //Save Draft
            Console.WriteLine("Colorsss");
            
            Save_Draft_Btn_Color = SaveDraft.ElementAt(0).GetCssValue("background-color");
            Console.WriteLine(Save_Draft_Btn_Color+"Color");
            Enroment_create_page_Url = Web_Driver.driver.Url;
            Console.WriteLine(Enroment_create_page_Url);
            SaveDraft.ElementAt(0).Click();
           

            Save_Draft_Btn_Color1 = SaveDraft.ElementAt(0).GetCssValue("background-color");
            Console.WriteLine(Save_Draft_Btn_Color1+"Color-");
            //Draft Button cliking verifying 

            Asserts.Save_Draft(Save_Draft_Btn_Color,Save_Draft_Btn_Color1);
           Web_Driver.ngWebDriver.WaitForAngular();
            Web_Driver.driver.Navigate().Refresh();


            Enroment_Search_page_Url = Web_Driver.driver.Url;
          
            Console.WriteLine(Enroment_Search_page_Url);
            Asserts.En_Search_Create_pages_Url(Enroment_create_page_Url,Enroment_Search_page_Url);
            //Getting New Record 
            Web_Driver.ngWebDriver.WaitForAngular();
           
            
            //Search for Updated Enrolment
            Thread.Sleep(3000);
            Hash_Drop.ElementAt(0).Click();
            //Search by Id
            Search_Records.ElementAt(0).Click();
            Thread.Sleep(3000);
           
            Search_Records.ElementAt(0).SendKeys(Edit_Id);
          
            Thread.Sleep(3000);
           
            Search_btn.ElementAt(0).Click();
            Thread.Sleep(3000);
            //Getting text of updated record
            Edit_Record_Updated = Edit_Record.Text;
            Console.WriteLine(Edit_Record_Updated + " Updated Record");
            //Assertion For Edit Record check
            Asserts.Edit_Record_Update(Edit_Record_Previous,Edit_Record_Updated);
            return new EA_POM();
        }
        public void Double()
        {
            Actions actions = new Actions(Web_Driver.driver);
            //WebElement elementLocator = driver.findElement(By.id("ID"));
            if (Double_click[0] == true)
            {
                actions.DoubleClick(Hash_Drop.ElementAt(0)).Perform();
                Double_click[0] = false;
            }
            if (Double_click[1] == true)
            {
                actions.DoubleClick(Hash_Drop.ElementAt(1)).Perform();
                Double_click[1] = false;
            }
            if (Double_click[2] == true)
            {
                actions.DoubleClick(Hash_Drop.ElementAt(2)).Perform();
                Double_click[2] = false;
            }
            if (Double_click[3] == true)
            {
                actions.DoubleClick(Hash_Drop.ElementAt(3)).Perform();
                Double_click[3] = false;
            }
            if (Double_click[4] == true)
            {
                actions.DoubleClick(Hash_Drop.ElementAt(4)).Perform();
                Double_click[4] = false;
            }
        }
    }
    }


