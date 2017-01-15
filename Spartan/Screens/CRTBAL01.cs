using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRTBAL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRTBAL01", "FormName");
		//Fields


        public static WinFormsField CrtbalKey0 = new WinFormsField("CRTBAL-KEY0", "CrtbalKey0");
        public static WinFormsField CertUnitsBalance = new WinFormsField("CERT-UNITS-BALANCE", "CertUnitsBalance");
        public static WinFormsField CertIssueDate = new WinFormsField("CERT-ISSUE-DATE", "CertIssueDate");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField CertMaturityDate = new WinFormsField("CERT-MATURITY-DATE", "CertMaturityDate");
        public static WinFormsField CertRunCreated = new WinFormsField("CERT-RUN-CREATED", "CertRunCreated");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CertRunChanged = new WinFormsField("CERT-RUN-CHANGED", "CertRunChanged");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CertTrnNumber = new WinFormsField("CERT-TRN-NUMBER", "CertTrnNumber");
        public static WinFormsField CertIndicator = new WinFormsField("CERT-INDICATOR", "CertIndicator");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField CertCallStatus = new WinFormsField("CERT-CALL-STATUS", "CertCallStatus");
        public static WinFormsField CertOrigin = new WinFormsField("CERT-ORIGIN", "CertOrigin");
        public static WinFormsField AdhocRunVersion = new WinFormsField("ADHOC-RUN-VERSION", "AdhocRunVersion");
        public static WinFormsField OverrideApplyInd = new WinFormsField("OVERRIDE-APPLY-IND", "OverrideApplyInd");
        public static WinFormsField CalcAdnUnitsInd = new WinFormsField("CALC-ADN-UNITS-IND", "CalcAdnUnitsInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
