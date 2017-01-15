using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBPC0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBPC0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField DividendCode1 = new WinFormsField("DIVIDEND-CODE1", "DividendCode1");
        public static WinFormsField PaymentDate1 = new WinFormsField("PAYMENT-DATE1", "PaymentDate1");
        public static WinFormsField DividendCode2 = new WinFormsField("DIVIDEND-CODE2", "DividendCode2");
        public static WinFormsField PaymentDate2 = new WinFormsField("PAYMENT-DATE2", "PaymentDate2");
        public static WinFormsField ReportSequence = new WinFormsField("REPORT-SEQUENCE", "ReportSequence");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField ProduceTape = new WinFormsField("PRODUCE-TAPE", "ProduceTape");
        public static WinFormsField OnlyInterim = new WinFormsField("ONLY-INTERIM", "OnlyInterim");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
