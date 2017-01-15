using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL03501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL03501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField TransactionDate = new WinFormsField("TRANSACTION-DATE", "TransactionDate");
        public static WinFormsField OffLoanType = new WinFormsField("OFF-LOAN-TYPE", "OffLoanType");
        public static WinFormsField OffLoanNumber = new WinFormsField("OFF-LOAN-NUMBER", "OffLoanNumber");
        public static WinFormsField OffMaturityDate = new WinFormsField("OFF-MATURITY-DATE", "OffMaturityDate");
        public static WinFormsField OffInterestRate = new WinFormsField("OFF-INTEREST-RATE", "OffInterestRate");
        public static WinFormsField RolloverAmt = new WinFormsField("ROLLOVER-AMT", "RolloverAmt");
        public static WinFormsField CertNum = new WinFormsField("CERT-NUM", "CertNum");
        public static WinFormsField SearchCriteria = new WinFormsField("SEARCH-CRITERIA", "SearchCriteria");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
