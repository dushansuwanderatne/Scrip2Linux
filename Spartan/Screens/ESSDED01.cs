using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSDED01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSDED01", "FormName");
		//Fields


        public static WinFormsField EssdedKey0 = new WinFormsField("ESSDED-KEY0", "EssdedKey0");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField AccumPeriod = new WinFormsField("ACCUM-PERIOD", "AccumPeriod");
        public static WinFormsField AccumStartDate = new WinFormsField("ACCUM-START-DATE", "AccumStartDate");
        public static WinFormsField AccumEndDate = new WinFormsField("ACCUM-END-DATE", "AccumEndDate");
        public static WinFormsField MaxNumberPayments = new WinFormsField("MAX-NUMBER-PAYMENTS", "MaxNumberPayments");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
