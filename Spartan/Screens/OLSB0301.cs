using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0301", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField TotalCount = new WinFormsField("TOTAL-COUNT", "TotalCount");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField SessionCount = new WinFormsField("SESSION-COUNT", "SessionCount");
        public static WinFormsField SessionTotal = new WinFormsField("SESSION-TOTAL", "SessionTotal");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField MarketValue = new WinFormsField("MARKET-VALUE", "MarketValue");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BsbCode = new WinFormsField("BSB-CODE", "BsbCode");
        public static WinFormsField BsbAccNumber = new WinFormsField("BSB-ACC-NUMBER", "BsbAccNumber");
        public static WinFormsField NZAccountPrefix = new WinFormsField("NZ-ACCOUNT-PREFIX", "NZAccountPrefix");
        public static WinFormsField NZAccountSuffix = new WinFormsField("NZ-ACCOUNT-SUFFIX", "NZAccountSuffix");
        public static WinFormsField BsbAccountName = new WinFormsField("BSB-ACCOUNT-NAME", "BsbAccountName");
        public static WinFormsField FreeFormatNote = new WinFormsField("FREE-FORMAT-NOTE", "FreeFormatNote");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
