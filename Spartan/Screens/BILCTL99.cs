using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BILCTL99

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BILCTL99", "FormName");
		//Fields
        public static WinFormsField ThirdPartyRep = new WinFormsField("3RD-PARTY-REP", "3rdPartyRep");
        public static WinFormsField ServiceProvider = new WinFormsField("SERVICE-PROVIDER", "ServiceProvider");
        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "ServiceCode");
    }
}
