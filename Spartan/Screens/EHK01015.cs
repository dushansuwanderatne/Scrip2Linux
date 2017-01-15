using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01015

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01015", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField AccumPeriod = new WinFormsField("ACCUM-PERIOD", "AccumPeriod");
        public static WinFormsField AccumStartDate = new WinFormsField("ACCUM-START-DATE", "AccumStartDate");
        public static WinFormsField AccumEndDate = new WinFormsField("ACCUM-END-DATE", "AccumEndDate");
        public static WinFormsField MaxNumberPayments = new WinFormsField("MAX-NUMBER-PAYMENTS", "MaxNumberPayments");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}