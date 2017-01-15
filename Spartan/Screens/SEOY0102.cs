using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEOY0102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEOY0102", "FormName");
		//Fields


        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField Recalc = new WinFormsField("RECALC", "Recalc");
        public static WinFormsField RecalcApplyAll = new WinFormsField("RECALC-APPLY-ALL", "RecalcApplyAll");
        public static WinFormsField MoreAccounts = new WinFormsField("MORE-ACCOUNTS", "MoreAccounts");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
