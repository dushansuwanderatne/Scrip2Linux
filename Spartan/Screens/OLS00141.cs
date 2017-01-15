using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00141

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00141", "FormName");
		//Fields


        public static WinFormsField MenuItemPay = new WinFormsField("MENU-ITEM-PAY", "PAY. Payment/Cheque Transactions", "Payment/ChequeTransactions");
        public static WinFormsField MenuItemPpm = new WinFormsField("MENU-ITEM-PPM", "PPM. Pending Payment Maintenance", "PendingPaymentMaintenance");
        public static WinFormsField MenuItemRap = new WinFormsField("MENU-ITEM-RAP", "RAP. Review Approvals", "ReviewApprovals");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
