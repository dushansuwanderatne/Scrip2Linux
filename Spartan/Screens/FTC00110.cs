using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00110

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00110", "FormName");
		//Fields


        public static WinFormsField WinTeam = new WinFormsField("WIN-TEAM", "WinTeam");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
