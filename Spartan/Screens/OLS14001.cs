using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS14001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS14001", "FormName");
		//Fields


        public static WinFormsField FilterHolderID = new WinFormsField("FILTER-HOLDER-ID", "FilterHolderID");
        public static WinFormsField FilterState = new WinFormsField("FILTER-STATE", "FilterState");
        public static WinFormsField FilterStepID = new WinFormsField("FILTER-STEP-ID", "FilterStepID");
        public static WinFormsField FilterDaysINProg = new WinFormsField("FILTER-DAYS-IN-PROG", "FilterDaysINProg");
        public static WinFormsField FilterPaymentAccount = new WinFormsField("FILTER-PAYMENT-ACCOUNT", "FilterPaymentAccount");
        public static WinFormsField FilterSuspendInd = new WinFormsField("FILTER-SUSPEND-IND", "FilterSuspendInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
