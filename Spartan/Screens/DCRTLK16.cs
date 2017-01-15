using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCRTLK16

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCRTLK16", "FormName");
		//Fields


        public static WinFormsField SellCert = new WinFormsField("SELL-CERT", "SellCert");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
        public static WinFormsField SellTransDate = new WinFormsField("SELL-TRANS-DATE", "SellTransDate");
        public static WinFormsField SellCertIndicator = new WinFormsField("SELL-CERT-INDICATOR", "SellCertIndicator");
        public static WinFormsField SellCreatedThisRun = new WinFormsField("SELL-CREATED-THIS-RUN", "SellCreatedThisRun");
    }
}
