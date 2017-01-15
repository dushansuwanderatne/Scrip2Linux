using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL06005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL06005", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField FromVestingCode = new WinFormsField("FROM-VESTING-CODE", "FromVestingCode");
        public static WinFormsField TOVestingCode = new WinFormsField("TO-VESTING-CODE", "TOVestingCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField FromPerformanceCode = new WinFormsField("FROM-PERFORMANCE-CODE", "FromPerformanceCode");
        public static WinFormsField TOPerformanceCode = new WinFormsField("TO-PERFORMANCE-CODE", "TOPerformanceCode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
