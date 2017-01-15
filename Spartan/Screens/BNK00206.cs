using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNK00206

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNK00206", "FormName");
		//Fields


        public static WinFormsField PrintBatchID = new WinFormsField("PRINT-BATCH-ID", "PrintBatchID");
        public static WinFormsField BatchTypeDesc = new WinFormsField("BATCH-TYPE-DESC", "BatchTypeDesc");
        public static WinFormsField BatchUrgentInd = new WinFormsField("BATCH-URGENT-IND", "BatchUrgentInd");
        public static WinFormsField TotalAccounts = new WinFormsField("TOTAL-ACCOUNTS", "TotalAccounts");
        public static WinFormsField TotalCompanies = new WinFormsField("TOTAL-COMPANIES", "TotalCompanies");
        public static WinFormsField TotalItems = new WinFormsField("TOTAL-ITEMS", "TotalItems");
        public static WinFormsField TotalChqAmt = new WinFormsField("TOTAL-CHQ-AMT", "TotalChqAmt");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField BatchUrgentDesc = new WinFormsField("BATCH-URGENT-DESC", "BatchUrgentDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
