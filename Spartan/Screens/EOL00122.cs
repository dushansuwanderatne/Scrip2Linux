using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00122

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00122", "FormName");
		//Fields
        public static WinFormsField MenuItemPay = new WinFormsField("MENU-ITEM-PAY", "PAY. Payment", "Payment");
        public static WinFormsField MenuItemRmn = new WinFormsField("MENU-ITEM-RMN", "RMN. Manual Regular Payment", "ManualRegularPayment");
        public static WinFormsField MenuItemAmn = new WinFormsField("MENU-ITEM-AMN", "AMN. Manual Adhoc Payment", "ManualAdhocPayment");
        public static WinFormsField MenuItemImn = new WinFormsField("MENU-ITEM-IMN", "IMN. Manual Interest Payment", "ManualInterestPayment");
        public static WinFormsField MenuItemRvm = new WinFormsField("MENU-ITEM-RVM", "RVM. Payment Reversal", "PaymentReversal");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemIrv = new WinFormsField("MENU-ITEM-IRV", "IRV. Interest Payment Reversal", "InterestPaymentReversal");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
