using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR01025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR01025", "FormName");
		//Fields


        public static WinFormsField VScripIC = new WinFormsField("V-SCRIP-IC", "VScripIC");
        public static WinFormsField VScripAuthTol = new WinFormsField("V-SCRIP-AUTH-TOL", "VScripAuthTol");
        public static WinFormsField ScripReconStatus = new WinFormsField("SCRIP-RECON-STATUS", "ScripReconStatus");
        public static WinFormsField VAsxIC = new WinFormsField("V-ASX-IC", "VAsxIC");
        public static WinFormsField VAsxAuthTol = new WinFormsField("V-ASX-AUTH-TOL", "VAsxAuthTol");
        public static WinFormsField AsxReconStatus = new WinFormsField("ASX-RECON-STATUS", "AsxReconStatus");
        public static WinFormsField VScripICSign = new WinFormsField("V-SCRIP-IC-SIGN", "VScripICSign");
        public static WinFormsField VScripAuthSign = new WinFormsField("V-SCRIP-AUTH-SIGN", "VScripAuthSign");
        public static WinFormsField VAsxICSign = new WinFormsField("V-ASX-IC-SIGN", "VAsxICSign");
        public static WinFormsField VAsxAuthSign = new WinFormsField("V-ASX-AUTH-SIGN", "VAsxAuthSign");
    }
}
