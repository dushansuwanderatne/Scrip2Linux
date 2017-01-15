using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00112

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00112", "FormName");
		//Fields


        public static WinFormsField MenuItemEspar = new WinFormsField("MENU-ITEM-ESPAR", "ESPAR. Payment Return (no interest)", "PaymentReturn(nointerest)");
        public static WinFormsField MenuItemEsopr = new WinFormsField("MENU-ITEM-ESOPR", "ESOPR. Overpayment Return (no interest)", "OverpaymentReturn(nointerest)");
        public static WinFormsField MenuItemEsrvc = new WinFormsField("MENU-ITEM-ESRVC", "ESRVC. Payment Return Reversal", "PaymentReturnReversal");
        public static WinFormsField MenuItemEsrvm = new WinFormsField("MENU-ITEM-ESRVM", "ESRVM. Monthly Payment Reversal", "MonthlyPaymentReversal");
        public static WinFormsField MenuItemEspra = new WinFormsField("MENU-ITEM-ESPRA", "ESPRA. Monthly Payment Re-applied", "MonthlyPaymentRe-applied");
        public static WinFormsField MenuItemEsrvb = new WinFormsField("MENU-ITEM-ESRVB", "ESRVB. Bonus Payment Reversal", "BonusPaymentReversal");
        public static WinFormsField MenuItemEsbra = new WinFormsField("MENU-ITEM-ESBRA", "ESBRA. Bonus Payment Re-applied", "BonusPaymentRe-applied");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
