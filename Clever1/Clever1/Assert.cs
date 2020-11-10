using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clever1
{
    class Asserts
    {
        public static void Log_Invalid_Assert_Title(string titlelog,string hometitle)
        {
            Assert.AreEqual(titlelog,hometitle,"Invalid failed");
        }
        public static void Log_Invalid_Assert_Url(string logurl, string homeurl)
        {
            Assert.AreNotEqual(logurl, homeurl, "Invalid failed");
        }
        public static void Log_Invalid_Text(string invldtxt)
        {
            Assert.AreEqual(invldtxt, "Invalid username or password", "Invalid failed");
        }
        public static void valid_Assert_Url(string logurl, string homeurl)
        {
            Assert.AreEqual(logurl, homeurl, "Login failed");
        }
        public static void Log_valid_Assert_Title(string titlelog, string hometitle)
        {
            Assert.AreNotEqual(titlelog, hometitle, "Login failed");
        }
        public static void Assert_Log_Text(string logtxt)
        {
            Assert.AreEqual(logtxt, "Hello, Ali Noon!", "Logout button not working");
        }
        public static void valid_Assert_logout_Url(string logurl, string homeurl)
        {
            Assert.AreNotEqual(logurl, homeurl, "Log out Failed");
        }
        public static void Enrolment_Page_Url(string Enrolurl, string homeurl)
        {
            Assert.AreNotEqual(Enrolurl, homeurl, "Enrolment Tab not clicking");
        }
        public static void Assert_Del_Record_Text(string recordtxt)
        {
            Assert.AreEqual(recordtxt, "Are you sure you want to delete this record?", "Delete record form not appeard");
        }
        public static void Assert_Del_No(string recordtxt)
        {
            Assert.AreEqual(recordtxt, "No", "No button of delete record form not working");
        }
        public static void Assert_Del_Yes(string recordtxt)
        {
            Assert.AreEqual(recordtxt, "Yes", "Yes button of delete record form not working");
        }
        public static void Delete_Id_Comparison(int previousid, int newid)
        {
            Assert.AreNotEqual(previousid, newid, "Delete record Failed");
        }
        public static void Url_Create_En(string enrul, string createurl)
        {
            Assert.AreNotEqual(enrul, createurl, "Enrolment create page not load");
        }
        public static void Assert_Plans(bool verify)
        {
            Assert.IsTrue(verify,"Plan txt not found");
        }
        public static void Assert_Plans1(bool verify)
        {
            Assert.IsTrue(verify, "Plan1 txt not found");
        }
        public static void Assert_Radiobtn(bool verify)
        {
            Assert.IsTrue(verify, "Radio btn not clicked");
        }
        public static void Assert_Section_Inputs(bool verify)
        {
            Assert.IsTrue(verify, "data not filled");
        }
        public static void Mailing_Checkbox(bool verify)
        {
            Assert.IsTrue(verify, "Checkbox not filled");
        }
        public static void Section2_Checkbox(bool verify)
        {
            Assert.IsTrue(verify, "Checkbox not filled");
        }
        public static void Assert_Search_btn(bool verify)
        {
            Assert.IsTrue(verify, "Search button not Clicked");
        }
        public static void Assert_Id_Found(bool verify)
        {
            Assert.IsTrue(verify, "Id Result not Found");
        }
        public static void Assert_Search_Clear(bool verify)
        {
            Assert.IsTrue(verify, "Clear button not Clicked");
        }
        public static void Assert_Name_Found(bool verify)
        {
            Assert.IsTrue(verify, "Name Records not Found");
        }
        public static void Assert_Email_Found(bool verify)
        {
            Assert.IsTrue(verify, "Email Records not Found");
        }
        public static void Assert_Plan_Found(bool verify)
        {
            Assert.IsTrue(verify, "Plan Records not Found");
        }
        public static void Date_Comparison(string latest, string last)
        {
            Assert.AreNotEqual(latest, last, "Dates are same so sorting Failed");
        }
        public static void Assert_Status_Found(bool verify)
        {
            Assert.IsTrue(verify, "Status Records not Found");
        }
        public static void Total_Count(bool verify)
        {
            Assert.IsTrue(verify, "Total Enrolment and Appointment text not found");
        }
        public static void Pay_list(bool verify)
        {
            Assert.IsTrue(verify,"Paylist failed");
        }
        public static void Pay_list1(bool verify)
        {
            Assert.IsTrue(verify, "Unchecked Paylist failed");
        }
        public static void Save_Draft(string previous_clr,string after_click_clr)
        {
            Assert.AreNotEqual(previous_clr,after_click_clr, "Save_Draft button not clicked");
        }
        public static void En_Search_Create_pages_Url(string Create_url, string Search_url)
        {
            Assert.AreNotEqual(Search_url, Create_url, "Search Enrolment page not LOaded");
        }
        public static void En_Search_Create_pages_Fields_Edit(bool verify)
        {
            Assert.IsTrue(verify, "Record not changed successfully");
        }
        public static void Edit_Record_Update(string pre_recodr,string up_record)
        {
            Assert.AreEqual(pre_recodr,up_record, "Record not Updated successfully");
        }
        public static void Enable_Fields(bool verify)
        {
            Assert.IsTrue(verify, "Checkbox Enable Input Boxes failed");
        }
        public static void All_Fields_Data_Filled(bool verify)
        {
            Assert.IsTrue(verify, "Input data missed");
        }
        public static void Date(bool verify)
        {
            Assert.IsTrue(verify, "Starting date bigger than Ending date");
        }
        public static void ID_Compare(int latest, int last)
        {
            Assert.AreNotEqual(latest, last, "ID'S are same so sorting Failed");
        }
    }
}
