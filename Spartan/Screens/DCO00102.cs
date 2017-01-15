using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCO00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCO00102", "FormName");
		//Fields


        public static WinFormsField ScreenTitle = new WinFormsField("SCREEN-TITLE", "ScreenTitle");
        public static WinFormsField SystemDetails = new WinFormsField("SYSTEM-DETAILS", "SystemDetails");
        public static WinFormsField DcrFileName = new WinFormsField("DCR-FILE-NAME", "DcrFileName");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField HomeBankDesc = new WinFormsField("HOME-BANK-DESC", "HomeBankDesc");
        public static WinFormsField PayDesc = new WinFormsField("PAY-DESC", "PayDesc");
        public static WinFormsField Bank = new WinFormsField("BANK", "Bank");
        public static WinFormsField Branch = new WinFormsField("BRANCH", "Branch");
        public static WinFormsField Account = new WinFormsField("ACCOUNT", "Account");
        public static WinFormsField Suffix = new WinFormsField("SUFFIX", "Suffix");
        public static WinFormsField WbcEftLinkUserID = new WinFormsField("WBC-EFT-LINK-USER-ID", "WbcEftLinkUserID");
        public static WinFormsField EftInd = new WinFormsField("EFT-IND", "EftInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
