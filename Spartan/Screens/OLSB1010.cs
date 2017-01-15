using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB1010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB1010", "FormName");
		//Fields
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField BulkCount = new WinFormsField("BULK-COUNT", "BulkCount");
        public static WinFormsField BulkUnits = new WinFormsField("BULK-UNITS", "BulkUnits");
        public static WinFormsField BulkMoney = new WinFormsField("BULK-MONEY", "BulkMoney");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField SessionCount = new WinFormsField("SESSION-COUNT", "SessionCount");
        public static WinFormsField SessionUnits = new WinFormsField("SESSION-UNITS", "SessionUnits");
        public static WinFormsField SessionMoney = new WinFormsField("SESSION-MONEY", "SessionMoney");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransUnits = new WinFormsField("TRANS-UNITS", "TransUnits");
        public static WinFormsField TransMoney = new WinFormsField("TRANS-MONEY", "TransMoney");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField NicAmount = new WinFormsField("NIC-AMOUNT", "NicAmount");
        public static WinFormsField PaySystem = new WinFormsField("PAY-SYSTEM", "PaySystem");
        public static WinFormsField BsbCode = new WinFormsField("BSB-CODE", "BsbCode");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField Message = new WinFormsField("MESSAGE", "Message");
        public static WinFormsField BsbAccNumber = new WinFormsField("BSB-ACC-NUMBER", "BsbAccNumber");
        public static WinFormsField NZAccountPrefix = new WinFormsField("NZ-ACCOUNT-PREFIX", "NZAccountPrefix");
        public static WinFormsField NZAccountSuffix = new WinFormsField("NZ-ACCOUNT-SUFFIX", "NZAccountSuffix");
        public static WinFormsField FreeFormatNote = new WinFormsField("FREE-FORMAT-NOTE", "FreeFormatNote");
        public static WinFormsField BsbAccountName = new WinFormsField("BSB-ACCOUNT-NAME", "BsbAccountName");
        public static WinFormsField WarnLine13 = new WinFormsField("WARN-LINE1-3", "WarnLine13");
        public static WinFormsField WarnLine46 = new WinFormsField("WARN-LINE4-6", "WarnLine46");
        public static WinFormsField TransStatusDesc = new WinFormsField("TRANS-STATUS-DESC", "TransStatusDesc");
        public static WinFormsField EnquiryAction = new WinFormsField("ENQUIRY-ACTION", "EnquiryAction");
        public static WinFormsField AuditAction = new WinFormsField("AUDIT-ACTION", "AuditAction");
        public static WinFormsField UpdateAction = new WinFormsField("UPDATE-ACTION", "UpdateAction");
        public static WinFormsField SearchTransNbr = new WinFormsField("SEARCH-TRANS-NBR", "SearchTransNbr");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Line24 = new WinFormsField("LINE24", "Line24");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
