using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SMRD0201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SMRD0201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField OldPayAccount = new WinFormsField("OLD-PAY-ACCOUNT", "OldPayAccount");
        public static WinFormsField NewPayAccount = new WinFormsField("NEW-PAY-ACCOUNT", "NewPayAccount");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField Price = new WinFormsField("PRICE", "Price");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
