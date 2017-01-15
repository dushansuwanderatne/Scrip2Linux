using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRTBAL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRTBAL00", "FormName");
		//Fields


        public static WinFormsField CrtbalKey0 = new WinFormsField("CRTBAL-KEY0", "CrtbalKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
