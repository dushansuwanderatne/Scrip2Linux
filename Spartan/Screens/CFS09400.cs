using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS09400

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS09400", "FormName");
		//Fields


        public static WinFormsField CashReconcilCode = new WinFormsField("CASH-RECONCIL-CODE", "CashReconcilCode");
        public static WinFormsField CashDescription = new WinFormsField("CASH-DESCRIPTION", "CashDescription");
        public static WinFormsField BulkSystem = new WinFormsField("BULK-SYSTEM", "BulkSystem");
        public static WinFormsField ContactName = new WinFormsField("CONTACT-NAME", "ContactName");
        public static WinFormsField BHTelephone = new WinFormsField("BH-TELEPHONE", "BHTelephone");
        public static WinFormsField AHTelephone = new WinFormsField("AH-TELEPHONE", "AHTelephone");
        public static WinFormsField FileTransferFlag = new WinFormsField("FILE-TRANSFER-FLAG", "FileTransferFlag");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField ReportDocumentArea = new WinFormsField("REPORT-DOCUMENT-AREA", "ReportDocumentArea");
        public static WinFormsField BrokerFeeFlag = new WinFormsField("BROKER-FEE-FLAG", "BrokerFeeFlag");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField PayeeAccountNumber = new WinFormsField("PAYEE-ACCOUNT-NUMBER", "PayeeAccountNumber");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField PayeeAccountType = new WinFormsField("PAYEE-ACCOUNT-TYPE", "PayeeAccountType");
        public static WinFormsField EmailOwner = new WinFormsField("EMAIL-OWNER", "EmailOwner");
        public static WinFormsField EmailMembers = new WinFormsField("EMAIL-MEMBERS", "EmailMembers");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchCashCode = new WinFormsField("SEARCH-CASH-CODE", "SearchCashCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
