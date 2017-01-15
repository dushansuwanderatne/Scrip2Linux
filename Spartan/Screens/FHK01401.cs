using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01401", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClientPrefix = new WinFormsField("CLIENT-PREFIX", "ClientPrefix");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField AcnArbnType = new WinFormsField("ACN-ARBN-TYPE", "AcnArbnType");
        public static WinFormsField AustralianCoyNumber = new WinFormsField("AUSTRALIAN-COY-NUMBER", "AustralianCoyNumber");
        public static WinFormsField AbnNumber = new WinFormsField("ABN-NUMBER", "AbnNumber");
        public static WinFormsField BusinessBranch = new WinFormsField("BUSINESS-BRANCH", "BusinessBranch");
        public static WinFormsField FixedIntDebentFlag = new WinFormsField("FIXED-INT-DEBENT-FLAG", "FixedIntDebentFlag");
        public static WinFormsField AutoGenCertInd = new WinFormsField("AUTO-GEN-CERT-IND", "AutoGenCertInd");
        public static WinFormsField FidBondInd = new WinFormsField("FID-BOND-IND", "FidBondInd");
        public static WinFormsField FidDeductedInd = new WinFormsField("FID-DEDUCTED-IND", "FidDeductedInd");
        public static WinFormsField PrincipalRegister = new WinFormsField("PRINCIPAL-REGISTER", "PrincipalRegister");
        public static WinFormsField Country = new WinFormsField("COUNTRY", "Country");
        public static WinFormsField LastHolder = new WinFormsField("LAST-HOLDER", "LastHolder");
        public static WinFormsField CompanyClosed = new WinFormsField("COMPANY-CLOSED", "CompanyClosed");
        public static WinFormsField LastHldTransNbr = new WinFormsField("LAST-HLD-TRANS-NBR", "LastHldTransNbr");
        public static WinFormsField LastCrtTransNbr = new WinFormsField("LAST-CRT-TRANS-NBR", "LastCrtTransNbr");
        public static WinFormsField LastPayTransNbr = new WinFormsField("LAST-PAY-TRANS-NBR", "LastPayTransNbr");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
