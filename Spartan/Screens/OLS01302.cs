using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01302", "FormName");
		//Fields


        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField SearchPcode = new WinFormsField("SEARCH-PCODE", "SearchPcode");
        public static WinFormsField SearchBankName = new WinFormsField("SEARCH-BANK-NAME", "SearchBankName");
        public static WinFormsField SearchPostCode = new WinFormsField("SEARCH-POST-CODE", "SearchPostCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
