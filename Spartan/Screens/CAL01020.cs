using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CAL01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CAL01020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField XtractFilnam = new WinFormsField("XTRACT-FILNAM", "XtractFilnam");
        public static WinFormsField ListingRequired = new WinFormsField("LISTING-REQUIRED", "ListingRequired");
        public static WinFormsField ListHeading = new WinFormsField("LIST-HEADING", "ListHeading");
        public static WinFormsField ListProgName = new WinFormsField("LIST-PROG-NAME", "ListProgName");
        public static WinFormsField CertONList = new WinFormsField("CERT-ON-LIST", "CertONList");
        public static WinFormsField BankProcessing = new WinFormsField("BANK-PROCESSING", "BankProcessing");
        public static WinFormsField UnallocatedHolder = new WinFormsField("UNALLOCATED-HOLDER", "UnallocatedHolder");
        public static WinFormsField ExceptNotingNbr = new WinFormsField("EXCEPT-NOTING-NBR", "ExceptNotingNbr");
        public static WinFormsField PartialPayments = new WinFormsField("PARTIAL-PAYMENTS", "PartialPayments");
        public static WinFormsField FirstNoticeDate = new WinFormsField("FIRST-NOTICE-DATE", "FirstNoticeDate");
        public static WinFormsField SecondNoticeDate = new WinFormsField("SECOND-NOTICE-DATE", "SecondNoticeDate");
        public static WinFormsField CallDueDate = new WinFormsField("CALL-DUE-DATE", "CallDueDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
