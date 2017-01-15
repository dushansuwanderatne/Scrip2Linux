using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00902", "FormName");
		//Fields


        public static WinFormsField AwardDesc = new WinFormsField("AWARD-DESC", "AwardDesc");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
