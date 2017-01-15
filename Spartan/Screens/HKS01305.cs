using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01305

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01305", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranBillingGroup = new WinFormsField("TRAN-BILLING-GROUP", "TranBillingGroup");
        public static WinFormsField TranBillGroupDesc = new WinFormsField("TRAN-BILL-GROUP-DESC", "TranBillGroupDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        //public static WinFormsField 05ReinitiateSearch = new WinFormsField("05-REINITIATE-SEARCH", "05ReinitiateSearch");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
