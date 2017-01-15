using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS13001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS13001", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField StartingRef = new WinFormsField("STARTING-REF", "StartingRef");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField MailFilename = new WinFormsField("MAIL-FILENAME", "MailFilename");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
