using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01005", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField InterestType = new WinFormsField("INTEREST-TYPE", "InterestType");
        public static WinFormsField PaymentTypeFI = new WinFormsField("PAYMENT-TYPE-FI", "PaymentTypeFI");
        public static WinFormsField PaymentTypeDeb = new WinFormsField("PAYMENT-TYPE-DEB", "PaymentTypeDeb");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentDateFrom = new WinFormsField("PAYMENT-DATE-FROM", "PaymentDateFrom");
        public static WinFormsField PaymentDateTO = new WinFormsField("PAYMENT-DATE-TO", "PaymentDateTO");
        public static WinFormsField PaymentIssues = new WinFormsField("PAYMENT-ISSUES", "PaymentIssues");
        public static WinFormsField SpecialSplitProg = new WinFormsField("SPECIAL-SPLIT-PROG", "SpecialSplitProg");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
