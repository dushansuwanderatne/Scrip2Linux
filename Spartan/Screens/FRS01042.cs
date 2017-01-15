using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS01042

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS01042", "FormName");
		//Fields


        public static WinFormsField MenuItemAP = new WinFormsField("MENU-ITEM-AP", "AP. General Ledger Applications Extract", "GeneralLedgerApplicationsExtract");
        public static WinFormsField MenuItemPA = new WinFormsField("MENU-ITEM-PA", "PA. General Ledger Payment Accruals Extract", "GeneralLedgerPaymentAccrualsExtract");
        public static WinFormsField MenuItemRP = new WinFormsField("MENU-ITEM-RP", "RP. General Ledger Repurchase Extract", "GeneralLedgerRepurchaseExtract");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
