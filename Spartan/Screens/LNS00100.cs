using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS00100", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
    }
}
