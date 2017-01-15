using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10014

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10014", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CertFrom = new WinFormsField("CERT-FROM", "CertFrom");
        public static WinFormsField CertTO = new WinFormsField("CERT-TO", "CertTO");
        public static WinFormsField CertBalFrom = new WinFormsField("CERT-BAL-FROM", "CertBalFrom");
        public static WinFormsField CertBalTO = new WinFormsField("CERT-BAL-TO", "CertBalTO");
        public static WinFormsField MarkingInd = new WinFormsField("MARKING-IND", "MarkingInd");
        public static WinFormsField UnpaidPrincipalOnly = new WinFormsField("UNPAID-PRINCIPAL-ONLY", "UnpaidPrincipalOnly");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
