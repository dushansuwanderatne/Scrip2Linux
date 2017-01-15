using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS09001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS09001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField LinkDescription = new WinFormsField("LINK-DESCRIPTION", "LinkDescription");
        public static WinFormsField Decision = new WinFormsField("DECISION", "Decision");
        public static WinFormsField InputLinkType = new WinFormsField("INPUT-LINK-TYPE", "InputLinkType");
    }
}
