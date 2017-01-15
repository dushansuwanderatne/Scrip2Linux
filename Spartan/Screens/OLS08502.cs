using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08502", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderType = new WinFormsField("HOLDER-TYPE", "HolderType");
        public static WinFormsField RegLine = new WinFormsField("REG-LINE", "RegLine");
        public static WinFormsField RegLine6 = new WinFormsField("REG-LINE-6", "RegLine6");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField ResidencyInd = new WinFormsField("RESIDENCY-IND", "ResidencyInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
