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
    class Appointments_Page
    {
        public static int Previous_ID;
        public static int Updated_ID;
        public static bool Id_Bool = false;
        public static bool[] Double_click = new bool[8];
        public static bool Search_btn_bool = false;
        public static bool Search_btn1_bool = false;
        public static bool Search_btn2_bool = false;
        public static bool Clear_Bool = false;
        public static bool Clear_Bool_1 = false;
        public static bool Clear_Bool_2 = false;
        public static string Created_Last_Date;
        public static string Appoinment_Page_Url;
        public static string Home_Page_Url;
        public static string Created_Latest_Date;
        public static string Date_of_Appoinment;
        public static string Date_of_Appoinment_Complete;
        public static string Pre_Id;
        public static string Up_Id;

        [FindsBy(How = How.XPath, Using = "//a[@routerlink='/pages/appointments']")]
        public IList<IWebElement> Apponitment_Tab { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-striped']//tbody//tr[1]//td[4]")]
        public IWebElement Created_Date { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[text()='Create Scope of Appointment']")]
        public IWebElement Created_Appoinment_Button { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@class='form-control ng-untouched ng-pristine ng-valid']")]
        public IList <IWebElement> Enable_Input_Boxes { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='exampleCheck1']")]
        public IWebElement Check_Boxe { get; set; }
        [FindsBy(How = How.Name, Using = "RepresentativeFirstName")]
        public IWebElement Representative_First_Name { get; set; }
        [FindsBy(How = How.Name, Using = "RepresentativeLastName")]
        public IWebElement Representative_Last_Name { get; set; }
        [FindsBy(How = How.Name, Using = "RepresentativeBeneficiaryRelationship")]
        public IWebElement Representative_Relationship { get; set; }
        [FindsBy(How = How.Name, Using = "RepresentativePhoneNumber")]
        public IWebElement RepresentativePhoneNumber { get; set; }
        [FindsBy(How = How.Name, Using = "AgentFirstName")]
        public IWebElement AgentFirstName { get; set; }
        [FindsBy(How = How.Name, Using = "AgentLastName")]
        public IWebElement AgentLastName { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='AgentPhone']")]
        public IWebElement AgentPhone { get; set; }
        [FindsBy(How = How.Name, Using = "FirstName")]
      
        public IWebElement Beneficiary_First_Name { get; set; }
        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement LastName { get; set; }
        [FindsBy(How = How.Name, Using = "HomePhone")]
        public IWebElement HomePhone { get; set; }
        [FindsBy(How = How.Name, Using = "PermanentAddress")]
        public IWebElement PermanentAddress { get; set; }
        [FindsBy(How = How.Name, Using = "EmailAddress")]
        public IWebElement EmailAddress { get; set; }
        [FindsBy(How = How.Name, Using = "PlansRepresented")]
        public IWebElement PlansRepresented { get; set; }
        [FindsBy(How = How.Name, Using = "AppointmentOn")]
        public IWebElement AppointmentOn { get; set; }
        [FindsBy(How = How.Name, Using = "AppointmentCompletedOn")]
        public IWebElement AppointmentCompletedOn { get; set; }
        [FindsBy(How = How.Name, Using = "AgnetNPNIDNumber")]
        public IWebElement AgnetNPNIDNumber { get; set; }
        [FindsBy(How = How.Name, Using = "meetingDetails")]
        public IWebElement meetingDetails { get; set; }
        [FindsBy(How = How.Name, Using = "MediCareNumber")]
        public IWebElement MediCareNumber { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio']")]
        public IList <IWebElement> Radio_Btn_list { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary m-1']")]
        public IList<IWebElement> Genrete_Appoinment { get; set; }
        [FindsBy(How = How.Name, Using = "InitialOtherContactMethod")]
        public IWebElement InitialOtherContactMethod { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IList<IWebElement> Genrete_Appoinment_Yes_Btn { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IList<IWebElement> Genrete_Appoinment_Ok_Btn { get; set; }
        [FindsBy(How = How.XPath, Using = "//td[@class='font-weight-medium']")]
        public IList <IWebElement> Previous_ID_txt { get; set; }
        [FindsBy(How = How.XPath, Using = "//td[@class='font-weight-medium']")]
        public IList<IWebElement> Created_ID_txt { get; set; }
        public   Appointments_Page()
        {

            PageFactory.InitElements(Web_Driver.driver, this);


        }
        public EA_POM   Appointment_Search()
        {
            Thread.Sleep(4000);
            Apponitment_Tab.ElementAt(0).Click();
            Enrolment_Page page = new Enrolment_Page();
           
            Thread.Sleep(2000);
            //Clicking on DropDown

            page.Hash_Drop.ElementAt(0).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            page.Search_Records.ElementAt(0).Click();
            //Passing data into Search box
            page.Search_Records.ElementAt(0).SendKeys("1741");
            try
            {
                //Clicking on Search btn 
                page.Search_btn.ElementAt(0).Click();
                //getting button Element
               Search_btn_bool = page.Search_btn.ElementAt(0).Displayed;
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
            for (int i = 0; i < page.Search_Record_Results.Count; i++)
            {
                Thread.Sleep(3000);
                Text_Heightlight.highlight();
                Id_Bool = page.Search_Record_Results[i].Displayed;
                Console.WriteLine(page.Search_Record_Results[i].Text);
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
                page.Clear_Btn.ElementAt(0).Click();
                Clear_Bool = page.Clear_Btn.ElementAt(0).Displayed;

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
            page.Hash_Drop.ElementAt(0).Click();
            //Verifying Search With Name

            //Clicking on DropDown
            page.Hash_Drop.ElementAt(1).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            page.Search_Records.ElementAt(1).Click();
            //Passing data into Search box
            page.Search_Records.ElementAt(1).SendKeys("Usama");
            try
            {
                //Clicking on Search btn 
                page.Search_btn.ElementAt(1).Click();
                //getting button Element
                Search_btn1_bool = page.Search_btn.ElementAt(1).Displayed;
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
                bool[] Name_Bool = new bool[page.Search_Record_Results.Count];
                Console.WriteLine(page.Search_Record_Results.Count + "" +
                    " Records");
                for (i = 0; i < page.Search_Record_Results.Count; i++)
                {
                    Text_Heightlight.highlight1();
                    Name_Bool[i] = page.Search_Record_Results[i].Displayed;
                    Console.WriteLine(page.Search_Record_Results[i].Text);
                    if (Name_Bool[i] == true)
                    {

                        Asserts.Assert_Name_Found(Name_Bool[i]);
                    }

                }

                if (page.Search_Record_Results.Count == 0)
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
                page.Clear_Btn.ElementAt(1).Click();
                Clear_Bool_1 = page.Clear_Btn.ElementAt(1).Displayed;

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
            page.Hash_Drop.ElementAt(1).Click();
            //Verifying email Address
           

            //Verifying Created
            //Getting Latest date 
            Created_Latest_Date = Created_Date.Text;
            Text_Heightlight.highlight2();
            Console.WriteLine(Created_Latest_Date);
            page.Created_Click.Click();
            Thread.Sleep(3000);
            Created_Last_Date = Created_Date.Text;
            Console.WriteLine(Created_Last_Date);
            Asserts.Date_Comparison(Created_Latest_Date, Created_Last_Date);
            //Verifying Status 
            page.Hash_Drop.ElementAt(2).Click();
            Thread.Sleep(3000);
            //Clicking inside the Search box
            page.Search_Records.ElementAt(2).Click();
            //Passing data into Search box
            page.Search_Records.ElementAt(2).SendKeys("Draft");
            try
            {
                //Clicking on Search btn 

                page.Search_btn.ElementAt(3).Click();
                //getting button Element
                Search_btn2_bool = page.Search_btn.ElementAt(3).Displayed;
                Thread.Sleep(3000);
                //Search button verify
                if (Search_btn2_bool == true)
                {
                    Asserts.Assert_Search_btn(true);
                }
            }
            catch
            {
                Asserts.Assert_Search_btn(false);
            }
            //Verifying Search results
            Thread.Sleep(3000);
            Text_Heightlight.highlight3();
            try
            {
                int i;
                bool[] Status_Bool = new bool[page.Search_Record_Results.Count];
                for (i = 67; i < page.Search_Record_Results.Count; i++)
                {
                    Status_Bool[i] = page.Search_Record_Results[i].Displayed;
                   
                    Console.WriteLine(page.Search_Record_Results[i].Text);
                    if (Status_Bool[i] == true)
                    {

                        Asserts.Assert_Status_Found(Status_Bool[i]);
                    }
                }
                if (page.Search_Record_Results.Count == 0)
                {
                    Asserts.Assert_Status_Found(false);
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
                page.Clear_Btn.ElementAt(3).Click();
                Clear_Bool_2 = page.Clear_Btn.ElementAt(3).Displayed;

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
            page.Hash_Drop.ElementAt(2).Click();
           
           return new EA_POM();
        }
        public EA_POM   Appointment_Delete()
        {
            Enrolment_Page page = new Enrolment_Page();
            //Actually delting Appoinment here
            //Clicking on Appoinment Tab#
           
            Web_Driver.ngWebDriver.WaitForAngular();
            Web_Driver.driver.Navigate().Refresh();
            Apponitment_Tab.ElementAt(0).Click();

            page.Delete_Enrolment();
            return new EA_POM();
        }
        public EA_POM Create_Appoinment()
        {
           
          
            Web_Driver.ngWebDriver.WaitForAngular();
            Web_Driver.driver.Navigate().Refresh();
           
           
            Apponitment_Tab.ElementAt(0).Click();
            //Clicking on Create Appoinment Button
            Web_Driver.ngWebDriver.WaitForAngular();
            Pre_Id = Previous_ID_txt.ElementAt(0).Text;
            int.TryParse(Pre_Id, out Previous_ID);
            Web_Driver.ngWebDriver.WaitForAngular();
            Created_Appoinment_Button.Click();
            //getting Appoinment page Url
            Appoinment_Page_Url=Web_Driver.driver.Url;
            //Clicking on CheckBox
             Check_Boxe.Click();
            //Checking Fields are Enabled after cliking on Checkbox
           
            for(int i=0;i<Enable_Input_Boxes.Count;i++)
            {
                
                if(Enable_Input_Boxes.ElementAt(i).Enabled)
                {
                    Asserts.Enable_Fields(true);
                }
                if (Enable_Input_Boxes.ElementAt(i).Enabled==false)
                {
                    Asserts.Enable_Fields(false);
                }
               

            }
            //passing data into Fields
           // pass data into representative Form
            Representative_First_Name.SendKeys("Usama");
            Representative_First_Name.GetAttribute("value");
           
            Representative_Last_Name.SendKeys("Sohail");
            Representative_Last_Name.GetAttribute("value");
            Representative_Relationship.SendKeys("Cousin");
            Representative_Relationship.GetAttribute("value");
            RepresentativePhoneNumber.SendKeys("(234) 678-9874");

            string repres_str=RepresentativePhoneNumber.GetAttribute("value");
            //Passing Agent Info
            AgentFirstName.Clear();
            AgentFirstName.SendKeys("Ahad");
            AgentFirstName.GetAttribute("value");
            AgentLastName.Clear();
            AgentLastName.SendKeys("Ahmed");
            AgentLastName.GetAttribute("value");
           
            AgentPhone.Clear();

            AgentPhone.SendKeys("2346789874");
            string str_AgentPhone=AgentPhone.GetAttribute("value");
            str_AgentPhone = str_AgentPhone.Substring(str_AgentPhone.IndexOf("("));
            str_AgentPhone = str_AgentPhone.Replace("(","");
            str_AgentPhone = str_AgentPhone.Replace(")", "");
            str_AgentPhone = str_AgentPhone.Replace("-", "");
           
          //  Console.WriteLine(str_AgentPhone);


            //passing data into Benificiary 
            Beneficiary_First_Name.SendKeys("Mujeed");
            Beneficiary_First_Name.GetAttribute("value");
            LastName.SendKeys("Khan");
            LastName.GetAttribute("value");
            EmailAddress.SendKeys("usama.sohail@Speridian.com");
            HomePhone.SendKeys("2346789874");
            HomePhone.GetAttribute("value");
            PermanentAddress.SendKeys("72 house 342");
            //Checking radio buttons 
            for(int i=0;i<Radio_Btn_list.Count;i++)
            {
                Radio_Btn_list.ElementAt(i).Click();
                Console.WriteLine(Radio_Btn_list.ElementAt(i).Selected);
            }
            //Passing Data into other 
            InitialOtherContactMethod.SendKeys("Other");
            InitialOtherContactMethod.SendKeys("value");
            //passing data into plan 
            PlansRepresented.SendKeys("Plan A");
            PlansRepresented.GetAttribute("value");
            //passing dates  
            AppointmentOn.SendKeys("12/10/2020");
            AppointmentOn.GetAttribute("value");
            AppointmentCompletedOn.SendKeys("13/10/2020");
            AppointmentCompletedOn.GetAttribute("value");
            //passing data into Appointment Id 
         AgnetNPNIDNumber.SendKeys("Md-4554");
            AgnetNPNIDNumber.GetAttribute("value");
            
            //passing data into plan
            meetingDetails.SendKeys("Plan D");
            meetingDetails.GetAttribute("value");
          //  Medicare Number 
           MediCareNumber.SendKeys("Md-6783");
           MediCareNumber.GetAttribute("value");

            //  Asserts.All_Fields_Data_Filled if (Representative_First_Name.contains("[a-zA-Z0-9]+") && RepresentativePhoneNumber.contains("[0-9]+") == true);
            //  Asserts.All_Fields_Data_Filled(false);

            //Assertion On Data filled or Not 
         
            
            if (Representative_First_Name.GetAttribute("value") =="Usama"&&Representative_Last_Name.GetAttribute("value") == "Sohail" && Representative_Relationship.GetAttribute("value") == "Cousin"  && AgentFirstName.GetAttribute("value") == "Ahad" && AgentLastName.GetAttribute("value") =="Ahmed"&& str_AgentPhone == "234 6789874" && Beneficiary_First_Name.GetAttribute("value") == "Mujeed" && LastName.GetAttribute("value") =="Khan"&& repres_str == "(234) 678-9874" && PermanentAddress.GetAttribute("value") == "72 house 342" && EmailAddress.GetAttribute("value") =="usama.sohail@Speridian.com" &&PlansRepresented.GetAttribute("value") =="Plan A"&& AppointmentOn.GetAttribute("value") == "10/12/2020" && AppointmentCompletedOn.GetAttribute("value") == "10/13/2020" && AgnetNPNIDNumber.GetAttribute("value") == "Md-4554" && MediCareNumber.GetAttribute("value") == "Md-6783")
            {
               Asserts.All_Fields_Data_Filled(true);
            }
            else
            {
                Asserts.All_Fields_Data_Filled(false);
            }
            //Assertion on Date
            
            
            Date_of_Appoinment = AppointmentOn.GetAttribute("value");
            Date_of_Appoinment= Date_of_Appoinment.Substring(Date_of_Appoinment.IndexOf("/"));
            Date_of_Appoinment = Date_of_Appoinment.Replace("/","");
            // Complete Date
            Date_of_Appoinment_Complete  = AppointmentCompletedOn.GetAttribute("value");

            Date_of_Appoinment_Complete = Date_of_Appoinment_Complete.Substring(Date_of_Appoinment_Complete.IndexOf("/"));
            Date_of_Appoinment_Complete = Date_of_Appoinment_Complete.Replace("/","");
            


            int.TryParse(Date_of_Appoinment_Complete, out int Complete_Date);
            int.TryParse(Date_of_Appoinment, out int Start_Date);
            Console.WriteLine(Complete_Date);
            Console.WriteLine(Start_Date);
            if (Complete_Date>Start_Date)
            {
                Asserts.Date(true);
            }
            else
            {
                Asserts.Date(false);
            }
            //Clicking on E Sign button 
            Genrete_Appoinment.ElementAt(0).Click();
            Genrete_Appoinment_Yes_Btn.ElementAt(1).Click();
            Web_Driver.ngWebDriver.WaitForAngular();
            Genrete_Appoinment_Ok_Btn.ElementAt(1).Click();
            Web_Driver.ngWebDriver.WaitForAngular();
            Web_Driver.driver.Navigate().Refresh();
            Home_Page_Url = Web_Driver.driver.Url;
            Console.WriteLine(Home_Page_Url);
            Console.WriteLine(Appoinment_Page_Url);
            Web_Driver.ngWebDriver.WaitForAngular();
            Up_Id = Created_ID_txt.ElementAt(0).Text;
            int.TryParse(Up_Id, out Updated_ID);
            Asserts.ID_Compare(Updated_ID,Previous_ID);
            Console.WriteLine(Previous_ID);
            Console.WriteLine(Updated_ID);
            return new EA_POM();
        }
        public void Double()
        {
            Enrolment_Page page = new Enrolment_Page();
            
            Actions actions = new Actions(Web_Driver.driver);
            //WebElement elementLocator = driver.findElement(By.id("ID"));
            if (Double_click[0] == true)
            {
                actions.DoubleClick(page.Hash_Drop.ElementAt(0)).Perform();
                Double_click[0] = false;
            }
            if (Double_click[1] == true)
            {
                actions.DoubleClick(page.Hash_Drop.ElementAt(1)).Perform();
                Double_click[1] = false;
            }
            if (Double_click[2] == true)
            {
                actions.DoubleClick(page.Hash_Drop.ElementAt(2)).Perform();
                Double_click[2] = false;
            }
            if (Double_click[3] == true)
            {
                actions.DoubleClick(page.Hash_Drop.ElementAt(2)).Perform();
                Double_click[3] = false;
            }
            if (Double_click[4] == true)
            {
                actions.DoubleClick(page.Hash_Drop.ElementAt(2)).Perform();
                Double_click[4] = false;
            }
        }
    }
}
