using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPPABT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPPABT01", "FormName");
		//Fields


        public static WinFormsField SppabtKey0 = new WinFormsField("SPPABT-KEY0", "SppabtKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AbtAccountName = new WinFormsField("ABT-ACCOUNT-NAME", "AbtAccountName");
        public static WinFormsField AbtBsbNumber = new WinFormsField("ABT-BSB-NUMBER", "AbtBsbNumber");
        public static WinFormsField AbtAccountNumber = new WinFormsField("ABT-ACCOUNT-NUMBER", "AbtAccountNumber");
        public static WinFormsField AbtDebitAmount = new WinFormsField("ABT-DEBIT-AMOUNT", "AbtDebitAmount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
