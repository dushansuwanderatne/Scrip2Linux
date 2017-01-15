using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSCCM

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSCCM", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  All Certificate Balances", "AllCertificateBalances");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Marking Balances only", "MarkingBalancesonly");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
