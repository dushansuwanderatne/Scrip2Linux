using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCO00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCO00104", "FormName");
		//Fields


        public static WinFormsField ScreenTitle = new WinFormsField("SCREEN-TITLE", "ScreenTitle");
        public static WinFormsField SystemDetails = new WinFormsField("SYSTEM-DETAILS", "SystemDetails");
        public static WinFormsField DcrFileName = new WinFormsField("DCR-FILE-NAME", "DcrFileName");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField SortCode = new WinFormsField("SORT-CODE", "SortCode");
        public static WinFormsField Account = new WinFormsField("ACCOUNT", "Account");
        public static WinFormsField RemitterName = new WinFormsField("REMITTER-NAME", "RemitterName");
        public static WinFormsField EftInd = new WinFormsField("EFT-IND", "EftInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}