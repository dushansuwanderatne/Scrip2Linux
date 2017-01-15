using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSPLPI

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSPLPI", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderKey = new WinFormsField("HOLDER-KEY", "HolderKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderType = new WinFormsField("HOLDER-TYPE", "HolderType");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField ReferenceNumber = new WinFormsField("REFERENCE-NUMBER", "ReferenceNumber");
        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PrincipalAmount = new WinFormsField("PRINCIPAL-AMOUNT", "PrincipalAmount");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField AmountAccrued = new WinFormsField("AMOUNT-ACCRUED", "AmountAccrued");
        public static WinFormsField PayMethod = new WinFormsField("PAY-METHOD", "PayMethod");
        public static WinFormsField AmountCompounded = new WinFormsField("AMOUNT-COMPOUNDED", "AmountCompounded");
        public static WinFormsField CalcMethod = new WinFormsField("CALC-METHOD", "CalcMethod");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDesc = new WinFormsField("ISSUE-DESC", "IssueDesc");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField Interest = new WinFormsField("INTEREST", "Interest");
        public static WinFormsField FidRecovered = new WinFormsField("FID-RECOVERED", "FidRecovered");
        public static WinFormsField Tax = new WinFormsField("TAX", "Tax");
        public static WinFormsField FidTORecComp = new WinFormsField("FID-TO-REC-COMP", "FidTORecComp");
        public static WinFormsField Nett = new WinFormsField("NETT", "Nett");
        public static WinFormsField FidOwingComp = new WinFormsField("FID-OWING-COMP", "FidOwingComp");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
