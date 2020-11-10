using System;
using System.Collections.Generic;
using System.Text;

namespace Clever1
{
    class All_Calls
    {
        public static bool Delete_Enrolment_On = false;
      
        public static void Enrol_Calls()
        {
            Enrolment_Page Page = new Enrolment_Page();
            Login_Call.Login_page_valid();
            Page.Create_Enrolment();
           
        }
        public static void Enrol_Delete_Calls()
        {
            
            Delete_Enrolment_On = true;
            Enrolment_Page Page = new Enrolment_Page();
            Page.Delete_Enrolment();
            
        }
        public static void Enrolment_Search_Calls()
        {
            Enrolment_Page Page = new Enrolment_Page();
         // Page.Dash_Board();
           Page.Search_Enrolment();

        }
        public static void Enrolment_Edit_Calls()
        {
            Enrolment_Page Page = new Enrolment_Page();
            // Page.Dash_Board();
            Login_Call.Login_page_valid();
            Page.Edit_Enrolment();

        }
        public static void Appointment_Search_Calls()
        {
            Appointments_Page page = new Appointments_Page();
            page.Appointment_Search();
        }
        public static  void Dash_Board()
        {
            Enrolment_Page page= new Enrolment_Page();
            page.Dash_Board();
        }
        public static void Delete_Appoinment()
        {
            
            Delete_Enrolment_On = false;
            Appointments_Page page = new Appointments_Page();
            page.Appointment_Delete();
        }
        public static void Create_Appoinment()
        {

            
            Appointments_Page page = new Appointments_Page();
            page.Create_Appoinment();
        }
    }
}
