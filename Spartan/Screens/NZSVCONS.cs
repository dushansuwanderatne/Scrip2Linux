using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSVCONS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSVCONS", "FormName");
		//Fields


        public static WinFormsField PortNumber = new WinFormsField("PORT-NUMBER", "PortNumber");
        public static WinFormsField UserData = new WinFormsField("USER-DATA", "UserData");
    }
}
