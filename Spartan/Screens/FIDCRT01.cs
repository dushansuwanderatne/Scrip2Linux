using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDCRT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDCRT01", "FormName");
		//Fields


        public static WinFormsField FidcrtKey0 = new WinFormsField("FIDCRT-KEY0", "FidcrtKey0");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField PrincipalAmount = new WinFormsField("PRINCIPAL-AMOUNT", "PrincipalAmount");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField PaidAmount = new WinFormsField("PAID-AMOUNT", "PaidAmount");
        public static WinFormsField AmountAccrued = new WinFormsField("AMOUNT-ACCRUED", "AmountAccrued");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField AmountCompounded = new WinFormsField("AMOUNT-COMPOUNDED", "AmountCompounded");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField IntCalcFromDate = new WinFormsField("INT-CALC-FROM-DATE", "IntCalcFromDate");
        public static WinFormsField FidLiableInd = new WinFormsField("FID-LIABLE-IND", "FidLiableInd");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField FidBankPaysInd = new WinFormsField("FID-BANK-PAYS-IND", "FidBankPaysInd");
        public static WinFormsField FidStateCode = new WinFormsField("FID-STATE-CODE", "FidStateCode");
        public static WinFormsField CertRunCreated = new WinFormsField("CERT-RUN-CREATED", "CertRunCreated");
        public static WinFormsField FidOwing = new WinFormsField("FID-OWING", "FidOwing");
        public static WinFormsField CertRunChanged = new WinFormsField("CERT-RUN-CHANGED", "CertRunChanged");
        public static WinFormsField FidTORecover = new WinFormsField("FID-TO-RECOVER", "FidTORecover");
        public static WinFormsField CertTrnNumber = new WinFormsField("CERT-TRN-NUMBER", "CertTrnNumber");
        public static WinFormsField ONCallInd = new WinFormsField("ON-CALL-IND", "ONCallInd");
        public static WinFormsField OriginalIcfDate = new WinFormsField("ORIGINAL-ICF-DATE", "OriginalIcfDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
