using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS41080

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS41080", "FormName");
		//Fields


        public static WinFormsField TransferNbr = new WinFormsField("TRANSFER-NBR", "TransferNbr");
        public static WinFormsField CertificateID = new WinFormsField("CERTIFICATE-ID", "CertificateID");
        public static WinFormsField Text = new WinFormsField("TEXT", "Text");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
