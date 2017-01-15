using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00413

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00413", "FormName");
		//Fields


        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
    }
}
