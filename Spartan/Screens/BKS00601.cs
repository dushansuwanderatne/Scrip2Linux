using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00601", "FormName");
		//Fields


        public static WinFormsField BankJurisdiction = new WinFormsField("BANK-JURISDICTION", "BankJurisdiction");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField ChangeDate = new WinFormsField("CHANGE-DATE", "ChangeDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField SearchJurisdiction = new WinFormsField("SEARCH-JURISDICTION", "SearchJurisdiction");
        public static WinFormsField SearchBankCode = new WinFormsField("SEARCH-BANK-CODE", "SearchBankCode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
