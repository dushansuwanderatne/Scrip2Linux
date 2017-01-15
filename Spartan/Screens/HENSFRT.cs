using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSFRT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSFRT", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Finding a transaction via run/transaction (both sides)", "Findingatransactionviarun/transaction(bothsides)");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Finding transaction/s for a run (or run/transaction) on holder", "Findingtransaction/sforarun(orrun/transaction)onholder");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Finding transaction/s for a holder with reference/TOTR/TETR", "Findingtransaction/sforaholderwithreference/TOTR/TETR");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
