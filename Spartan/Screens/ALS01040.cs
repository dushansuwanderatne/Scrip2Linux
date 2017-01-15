using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01040", "FormName");
		//Fields


        public static WinFormsField FirstAltClass = new WinFormsField("FIRST-ALT-CLASS", "FirstAltClass");
        public static WinFormsField FirstAltClassDesc = new WinFormsField("FIRST-ALT-CLASS-DESC", "FirstAltClassDesc");
        public static WinFormsField FirstAltCertID = new WinFormsField("FIRST-ALT-CERT-ID", "FirstAltCertID");
        public static WinFormsField SecondAltClass = new WinFormsField("SECOND-ALT-CLASS", "SecondAltClass");
        public static WinFormsField SecondAltClassDesc = new WinFormsField("SECOND-ALT-CLASS-DESC", "SecondAltClassDesc");
        public static WinFormsField SecondAltCertID = new WinFormsField("SECOND-ALT-CERT-ID", "SecondAltCertID");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
