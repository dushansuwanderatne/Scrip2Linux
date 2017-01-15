using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP2504

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP2504", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField Division = new WinFormsField("DIVISION", "Division");
        public static WinFormsField Location = new WinFormsField("LOCATION", "Location");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
