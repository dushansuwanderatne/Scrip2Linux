using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS00711

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS00711", "FormName");
		//Fields
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField OptionPrice = new WinFormsField("OPTION-PRICE", "OptionPrice");
        public static WinFormsField CertBalance = new WinFormsField("CERT-BALANCE", "CertBalance");
        public static WinFormsField AvailBal = new WinFormsField("AVAIL-BAL", "AvailBal");
        public static WinFormsField SelectionNbrX = new WinFormsField("SELECTION-NBR-X", "SelectionNbrX");
        public static WinFormsField CertSelectionX = new WinFormsField("CERT-SELECTION-X", "CertSelectionX");
    }
}
