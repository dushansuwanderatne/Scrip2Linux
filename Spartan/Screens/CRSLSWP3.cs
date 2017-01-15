using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSLSWP3

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSLSWP3", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Form = new WinFormsField("FORM", "Form");
        public static WinFormsField CertificateShapeCount = new WinFormsField("CERTIFICATE-SHAPE-COUNT", "CertificateShapeCount");
        public static WinFormsField CertificateShape = new WinFormsField("CERTIFICATE-SHAPE", "CertificateShape");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
