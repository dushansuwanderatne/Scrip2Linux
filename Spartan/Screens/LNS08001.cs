using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS08001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS08001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField RecordTypeLiteral = new WinFormsField("RECORD-TYPE-LITERAL", "RecordTypeLiteral");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField RecordKey = new WinFormsField("RECORD-KEY", "RecordKey");
        public static WinFormsField RecordDescription = new WinFormsField("RECORD-DESCRIPTION", "RecordDescription");
        public static WinFormsField StatementInd = new WinFormsField("STATEMENT-IND", "StatementInd");
        public static WinFormsField StatementDescription = new WinFormsField("STATEMENT-DESCRIPTION", "StatementDescription");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField PaymentTypeDesc = new WinFormsField("PAYMENT-TYPE-DESC", "PaymentTypeDesc");
        public static WinFormsField ImputationRate = new WinFormsField("IMPUTATION-RATE", "ImputationRate");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField ClosingPrice = new WinFormsField("CLOSING-PRICE", "ClosingPrice");
        public static WinFormsField ClosingDate = new WinFormsField("CLOSING-DATE", "ClosingDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchClient = new WinFormsField("SEARCH-CLIENT", "SearchClient");
        public static WinFormsField SearchCompany = new WinFormsField("SEARCH-COMPANY", "SearchCompany");
        public static WinFormsField SearchRecType = new WinFormsField("SEARCH-REC-TYPE", "SearchRecType");
        public static WinFormsField SearchRecKey = new WinFormsField("SEARCH-REC-KEY", "SearchRecKey");
    }
}
