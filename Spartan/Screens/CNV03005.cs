using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNV03005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNV03005", "FormName");
		//Fields


        public static WinFormsField CompanyID = new WinFormsField("COMPANY-ID", "CompanyID");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField ForeignCode = new WinFormsField("FOREIGN-CODE", "ForeignCode");
        public static WinFormsField ScripCodeX5 = new WinFormsField("SCRIP-CODE-X5", "ScripCodeX5");
        public static WinFormsField ForeignDivCode = new WinFormsField("FOREIGN-DIV-CODE", "ForeignDivCode");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField PaymentDateDD = new WinFormsField("PAYMENT-DATE-DD", "PaymentDateDD");
        public static WinFormsField PaymentDateMM = new WinFormsField("PAYMENT-DATE-MM", "PaymentDateMM");
        public static WinFormsField PaymentDateCcyy = new WinFormsField("PAYMENT-DATE-CCYY", "PaymentDateCcyy");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCompanyID = new WinFormsField("SEARCH-COMPANY-ID", "SearchCompanyID");
        public static WinFormsField SearchRecordType = new WinFormsField("SEARCH-RECORD-TYPE", "SearchRecordType");
        public static WinFormsField SearchForeignCode = new WinFormsField("SEARCH-FOREIGN-CODE", "SearchForeignCode");
        public static WinFormsField AddRecordType = new WinFormsField("ADD-RECORD-TYPE", "AddRecordType");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField ImputationRate = new WinFormsField("IMPUTATION-RATE", "ImputationRate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
