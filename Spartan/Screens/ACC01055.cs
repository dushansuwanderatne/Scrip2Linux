using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01055

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01055", "FormName");
		//Fields


        public static WinFormsField SubSystemID = new WinFormsField("SUB-SYSTEM-ID", "SubSystemID");
        public static WinFormsField SubSystemDesc = new WinFormsField("SUB-SYSTEM-DESC", "SubSystemDesc");
        public static WinFormsField ReportDescription = new WinFormsField("REPORT-DESCRIPTION", "ReportDescription");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField PendingMoneyInd = new WinFormsField("PENDING-MONEY-IND", "PendingMoneyInd");
        public static WinFormsField EntOverpaymentsInd = new WinFormsField("ENT-OVERPAYMENTS-IND", "EntOverpaymentsInd");
        public static WinFormsField AdnOverpaymentsInd = new WinFormsField("ADN-OVERPAYMENTS-IND", "AdnOverpaymentsInd");
        public static WinFormsField TransactionType = new WinFormsField("TRANSACTION-TYPE", "TransactionType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
