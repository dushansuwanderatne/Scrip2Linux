using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS16050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS16050", "FormName");
		//Fields


        public static WinFormsField ScreenHeading = new WinFormsField("SCREEN-HEADING", "ScreenHeading");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
        public static WinFormsField NettORActual = new WinFormsField("NETT-OR-ACTUAL", "NettORActual");
        public static WinFormsField TraceBsb = new WinFormsField("TRACE-BSB", "TraceBsb");
        public static WinFormsField TraceAccount = new WinFormsField("TRACE-ACCOUNT", "TraceAccount");
        public static WinFormsField NettPayAmt = new WinFormsField("NETT-PAY-AMT", "NettPayAmt");
        public static WinFormsField PercentageBreakup = new WinFormsField("PERCENTAGE-BREAKUP", "PercentageBreakup");
        public static WinFormsField NettPayAmtTot = new WinFormsField("NETT-PAY-AMT-TOT", "NettPayAmtTot");
        public static WinFormsField PerBreakupTot = new WinFormsField("PER-BREAKUP-TOT", "PerBreakupTot");
        public static WinFormsField TargetLine = new WinFormsField("TARGET-LINE", "TargetLine");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField SharesLine = new WinFormsField("SHARES-LINE", "SharesLine");
        public static WinFormsField UserPassword = new WinFormsField("USER-PASSWORD", "UserPassword");
        public static WinFormsField BidderLine = new WinFormsField("BIDDER-LINE", "BidderLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
