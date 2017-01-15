using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSDISP

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSDISP", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Static details; address, notings, payee instructions, etc", "Staticdetails;address,notings,payeeinstructions,etc");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Holding (Total shares per Class/Register)", "Holding(TotalsharesperClass/Register)");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Certificate Balances", "CertificateBalances");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Register (Transactions)", "Register(Transactions)");
        public static WinFormsField MenuItem5 = new WinFormsField("MENU-ITEM-5", "5.  Payments", "Payments");
        public static WinFormsField MenuItem6 = new WinFormsField("MENU-ITEM-6", "6.  Plans", "Plans");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
