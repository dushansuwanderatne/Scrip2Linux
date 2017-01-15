using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYHIS11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYHIS11", "FormName");
		//Fields


        public static WinFormsField PayhisKey0 = new WinFormsField("PAYHIS-KEY0", "PayhisKey0");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField TotGrossAmt1 = new WinFormsField("TOT-GROSS-AMT1", "TotGrossAmt1");
        public static WinFormsField RefNOKey2 = new WinFormsField("REF-NO-KEY2", "RefNOKey2");
        public static WinFormsField TotGrossAmt2 = new WinFormsField("TOT-GROSS-AMT2", "TotGrossAmt2");
        public static WinFormsField PayMethodKey2 = new WinFormsField("PAY-METHOD-KEY2", "PayMethodKey2");
        public static WinFormsField TotTaxAmt = new WinFormsField("TOT-TAX-AMT", "TotTaxAmt");
        public static WinFormsField IssueNumberKey2 = new WinFormsField("ISSUE-NUMBER-KEY2", "IssueNumberKey2");
        public static WinFormsField FidTORecoverActual = new WinFormsField("FID-TO-RECOVER-ACTUAL", "FidTORecoverActual");
        public static WinFormsField CertNumberKey2 = new WinFormsField("CERT-NUMBER-KEY2", "CertNumberKey2");
        public static WinFormsField FidOwingCompound = new WinFormsField("FID-OWING-COMPOUND", "FidOwingCompound");
        public static WinFormsField CalcMethod = new WinFormsField("CALC-METHOD", "CalcMethod");
        public static WinFormsField FidTORecoverCompound = new WinFormsField("FID-TO-RECOVER-COMPOUND", "FidTORecoverCompound");
        public static WinFormsField TaxCode = new WinFormsField("TAX-CODE", "TaxCode");
        public static WinFormsField PrincipalAmount = new WinFormsField("PRINCIPAL-AMOUNT", "PrincipalAmount");
        public static WinFormsField AddressType = new WinFormsField("ADDRESS-TYPE", "AddressType");
        public static WinFormsField AmountAccrued = new WinFormsField("AMOUNT-ACCRUED", "AmountAccrued");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField AmountCompounded = new WinFormsField("AMOUNT-COMPOUNDED", "AmountCompounded");
        public static WinFormsField PaymentInstruction = new WinFormsField("PAYMENT-INSTRUCTION", "PaymentInstruction");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField TaxTypeIndicator = new WinFormsField("TAX-TYPE-INDICATOR", "TaxTypeIndicator");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField FidTORecover = new WinFormsField("FID-TO-RECOVER", "FidTORecover");
        public static WinFormsField MarkingIndicator = new WinFormsField("MARKING-INDICATOR", "MarkingIndicator");
        public static WinFormsField FidOwing = new WinFormsField("FID-OWING", "FidOwing");
        public static WinFormsField ChildTaxInd = new WinFormsField("CHILD-TAX-IND", "ChildTaxInd");
        public static WinFormsField IntCalcFromDate = new WinFormsField("INT-CALC-FROM-DATE", "IntCalcFromDate");
        public static WinFormsField ONCallInd = new WinFormsField("ON-CALL-IND", "ONCallInd");
        public static WinFormsField IntCalcTODate = new WinFormsField("INT-CALC-TO-DATE", "IntCalcTODate");
        public static WinFormsField CertRunCreated = new WinFormsField("CERT-RUN-CREATED", "CertRunCreated");
        public static WinFormsField ManualPaymentFlag = new WinFormsField("MANUAL-PAYMENT-FLAG", "ManualPaymentFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
