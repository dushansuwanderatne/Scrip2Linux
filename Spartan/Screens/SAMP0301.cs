using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SAMP0301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SAMP0301", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField AvgPrice = new WinFormsField("AVG-PRICE", "AvgPrice");
        public static WinFormsField Origin = new WinFormsField("ORIGIN", "Origin");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField Brokerage = new WinFormsField("BROKERAGE", "Brokerage");
        public static WinFormsField StampDuty = new WinFormsField("STAMP-DUTY", "StampDuty");
        public static WinFormsField AdminCosts = new WinFormsField("ADMIN-COSTS", "AdminCosts");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
