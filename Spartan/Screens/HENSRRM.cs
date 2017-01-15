using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSRRM

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSRRM", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Register of all transactions", "Registerofalltransactions");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Register of transactions on markings only", "Registeroftransactionsonmarkingsonly");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Register of transactions for a run", "Registeroftransactionsforarun");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Register of transactions for a trade reference/TOTR/TETR", "Registeroftransactionsforatradereference/TOTR/TETR");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
