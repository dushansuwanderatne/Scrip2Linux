using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEIS04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEIS04", "FormName");
		//Fields


        public static WinFormsField AllotDate = new WinFormsField("ALLOT-DATE", "AllotDate");
        public static WinFormsField TotalCash = new WinFormsField("TOTAL-CASH", "TotalCash");
        public static WinFormsField AllotValue = new WinFormsField("ALLOT-VALUE", "AllotValue");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField Slash = new WinFormsField("SLASH", "Slash");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
    }
}
