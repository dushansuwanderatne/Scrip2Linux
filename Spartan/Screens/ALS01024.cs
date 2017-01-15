using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01024

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01024", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CertInd = new WinFormsField("CERT-IND", "CertInd");
        public static WinFormsField CertIndDesc = new WinFormsField("CERT-IND-DESC", "CertIndDesc");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
