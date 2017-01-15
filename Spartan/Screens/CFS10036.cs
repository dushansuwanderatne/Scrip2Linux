using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10036

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10036", "FormName");
		//Fields


        public static WinFormsField Location = new WinFormsField("LOCATION", "Location");
        public static WinFormsField Program = new WinFormsField("PROGRAM", "Program");
    }
}
