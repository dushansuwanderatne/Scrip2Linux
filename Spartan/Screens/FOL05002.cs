using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL05002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL05002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField LodgementDate = new WinFormsField("LODGEMENT-DATE", "LodgementDate");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDesc = new WinFormsField("ISSUE-DESC", "IssueDesc");
        public static WinFormsField LoanType = new WinFormsField("LOAN-TYPE", "LoanType");
        public static WinFormsField LoanNumber = new WinFormsField("LOAN-NUMBER", "LoanNumber");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField Cert = new WinFormsField("CERT", "Cert");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField MarkingAmt = new WinFormsField("MARKING-AMT", "MarkingAmt");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField FidOwing = new WinFormsField("FID-OWING", "FidOwing");
        public static WinFormsField FidTORecover = new WinFormsField("FID-TO-RECOVER", "FidTORecover");
        public static WinFormsField AccruedTradingAmt = new WinFormsField("ACCRUED-TRADING-AMT", "AccruedTradingAmt");
        public static WinFormsField CompoundTradingAmt = new WinFormsField("COMPOUND-TRADING-AMT", "CompoundTradingAmt");
        public static WinFormsField CompoundGrossAmt = new WinFormsField("COMPOUND-GROSS-AMT", "CompoundGrossAmt");
        public static WinFormsField WarningMessage = new WinFormsField("WARNING-MESSAGE", "WarningMessage");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
