using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCO00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCO00101", "FormName");
		//Fields


        public static WinFormsField ScreenTitle = new WinFormsField("SCREEN-TITLE", "ScreenTitle");
        public static WinFormsField SystemDetails = new WinFormsField("SYSTEM-DETAILS", "SystemDetails");
        public static WinFormsField DcrFileName = new WinFormsField("DCR-FILE-NAME", "DcrFileName");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField HomeBankDesc = new WinFormsField("HOME-BANK-DESC", "HomeBankDesc");
        public static WinFormsField UserNum = new WinFormsField("USER-NUM", "UserNum");
        public static WinFormsField OverrideTranType = new WinFormsField("OVERRIDE-TRAN-TYPE", "OverrideTranType");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField TraceBsb = new WinFormsField("TRACE-BSB", "TraceBsb");
        public static WinFormsField TraceAccount = new WinFormsField("TRACE-ACCOUNT", "TraceAccount");
        public static WinFormsField TranRemitterName = new WinFormsField("TRAN-REMITTER-NAME", "TranRemitterName");
        public static WinFormsField EftInd = new WinFormsField("EFT-IND", "EftInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField BankOverrideText = new WinFormsField("BANK-OVERRIDE-TEXT", "BankOverrideText");
        public static WinFormsField OverrideBankDetails = new WinFormsField("OVERRIDE-BANK-DETAILS", "OverrideBankDetails");
        public static WinFormsField FundingBsb = new WinFormsField("FUNDING-BSB", "FundingBsb");
        public static WinFormsField FundingAccount = new WinFormsField("FUNDING-ACCOUNT", "FundingAccount");
        public static WinFormsField DirOverrideText = new WinFormsField("DIR-OVERRIDE-TEXT", "DirOverrideText");
        public static WinFormsField OverrideDirDetails = new WinFormsField("OVERRIDE-DIR-DETAILS", "OverrideDirDetails");
        public static WinFormsField OverrideDir = new WinFormsField("OVERRIDE-DIR", "OverrideDir");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
