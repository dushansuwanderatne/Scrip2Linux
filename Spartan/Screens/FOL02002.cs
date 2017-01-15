using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL02002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL02002", "FormName");
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
        public static WinFormsField CertNum = new WinFormsField("CERT-NUM", "CertNum");
        public static WinFormsField PrincipalAmt = new WinFormsField("PRINCIPAL-AMT", "PrincipalAmt");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AmountPaid = new WinFormsField("AMOUNT-PAID", "AmountPaid");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField AccruedAmount = new WinFormsField("ACCRUED-AMOUNT", "AccruedAmount");
        public static WinFormsField FidOwingAmt = new WinFormsField("FID-OWING-AMT", "FidOwingAmt");
        public static WinFormsField FidTORecover = new WinFormsField("FID-TO-RECOVER", "FidTORecover");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField WarningMessage = new WinFormsField("WARNING-MESSAGE", "WarningMessage");
        public static WinFormsField SourceOFFunds = new WinFormsField("SOURCE-OF-FUNDS", "SourceOFFunds");
        public static WinFormsField SourceOFFundsDesc = new WinFormsField("SOURCE-OF-FUNDS-DESC", "SourceOFFundsDesc");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
