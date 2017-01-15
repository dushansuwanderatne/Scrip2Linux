using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0302", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField CurrentBalance = new WinFormsField("CURRENT-BALANCE", "CurrentBalance");
        public static WinFormsField AvailableBalance = new WinFormsField("AVAILABLE-BALANCE", "AvailableBalance");
        public static WinFormsField PendingMoney = new WinFormsField("PENDING-MONEY", "PendingMoney");
        public static WinFormsField PendingUnits = new WinFormsField("PENDING-UNITS", "PendingUnits");
        public static WinFormsField ApplyDivInstr = new WinFormsField("APPLY-DIV-INSTR", "ApplyDivInstr");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField BsbCode = new WinFormsField("BSB-CODE", "BsbCode");
        public static WinFormsField HolderWarning = new WinFormsField("HOLDER-WARNING", "HolderWarning");
        public static WinFormsField BsbAccNumber = new WinFormsField("BSB-ACC-NUMBER", "BsbAccNumber");
        public static WinFormsField NZAccountPrefix = new WinFormsField("NZ-ACCOUNT-PREFIX", "NZAccountPrefix");
        public static WinFormsField NZAccountSuffix = new WinFormsField("NZ-ACCOUNT-SUFFIX", "NZAccountSuffix");
        public static WinFormsField ConfirmCorporate = new WinFormsField("CONFIRM-CORPORATE", "ConfirmCorporate");
        public static WinFormsField BankLine = new WinFormsField("BANK-LINE", "BankLine");
        public static WinFormsField ConfirmForeign = new WinFormsField("CONFIRM-FOREIGN", "ConfirmForeign");
        public static WinFormsField ConfirmPartial = new WinFormsField("CONFIRM-PARTIAL", "ConfirmPartial");
        public static WinFormsField ConfirmReturnMail = new WinFormsField("CONFIRM-RETURN-MAIL", "ConfirmReturnMail");
        public static WinFormsField BsbAccountName = new WinFormsField("BSB-ACCOUNT-NAME", "BsbAccountName");
        public static WinFormsField ConfirmDeceased = new WinFormsField("CONFIRM-DECEASED", "ConfirmDeceased");
        public static WinFormsField ConfirmUnits = new WinFormsField("CONFIRM-UNITS", "ConfirmUnits");
        public static WinFormsField BuyHolder = new WinFormsField("BUY-HOLDER", "BuyHolder");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
