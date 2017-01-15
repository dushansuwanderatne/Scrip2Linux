using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSCR

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSCR", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Certificate balances", "Certificatebalances");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Marking Balances", "MarkingBalances");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Transactions for Certificates", "TransactionsforCertificates");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Transactions for Markings", "TransactionsforMarkings");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
