using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSTRDSC

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSTRDSC", "FormName");
		//Fields
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField AwardPrice = new WinFormsField("AWARD-PRICE", "AwardPrice");
        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField GainLoss = new WinFormsField("GAIN-LOSS", "GainLoss");
    }
}
