using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS14004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS14004", "FormName");
		//Fields


        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField PayAccount = new WinFormsField("PAY-ACCOUNT", "PayAccount");
        public static WinFormsField PayMethod = new WinFormsField("PAY-METHOD", "PayMethod");
        public static WinFormsField PayReference = new WinFormsField("PAY-REFERENCE", "PayReference");
        public static WinFormsField PayMethodTO = new WinFormsField("PAY-METHOD-TO", "PayMethodTO");
        public static WinFormsField PaidAmount = new WinFormsField("PAID-AMOUNT", "PaidAmount");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField LineSelection = new WinFormsField("LINE-SELECTION", "LineSelection");
        public static WinFormsField StepCode = new WinFormsField("STEP-CODE", "StepCode");
        public static WinFormsField StepStatusDesc = new WinFormsField("STEP-STATUS-DESC", "StepStatusDesc");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField NoteTxtL1Ext = new WinFormsField("NOTE-TXT-L1-EXT", "NoteTxtL1Ext");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SelStep = new WinFormsField("SEL-STEP", "SelStep");
        public static WinFormsField NoteTxtL1 = new WinFormsField("NOTE-TXT-L1", "NoteTxtL1");
        public static WinFormsField NoteTxtL2 = new WinFormsField("NOTE-TXT-L2", "NoteTxtL2");
        public static WinFormsField NoteTxtL3 = new WinFormsField("NOTE-TXT-L3", "NoteTxtL3");
        public static WinFormsField NoteTxtL4 = new WinFormsField("NOTE-TXT-L4", "NoteTxtL4");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
