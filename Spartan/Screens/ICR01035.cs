using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR01035

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR01035", "FormName");
		//Fields


        public static WinFormsField VScripIC = new WinFormsField("V-SCRIP-IC", "VScripIC");
        public static WinFormsField VScripAuthTol = new WinFormsField("V-SCRIP-AUTH-TOL", "VScripAuthTol");
        public static WinFormsField ScripReconStatus = new WinFormsField("SCRIP-RECON-STATUS", "ScripReconStatus");
        public static WinFormsField VScripICSign = new WinFormsField("V-SCRIP-IC-SIGN", "VScripICSign");
        public static WinFormsField VScripAuthSign = new WinFormsField("V-SCRIP-AUTH-SIGN", "VScripAuthSign");
    }
}
