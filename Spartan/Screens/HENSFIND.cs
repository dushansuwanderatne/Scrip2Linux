using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSFIND

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSFIND", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Finding a holder", "Findingaholder");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Finding a certificate", "Findingacertificate");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Finding a transaction", "Findingatransaction");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Finding a payment", "Findingapayment");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
