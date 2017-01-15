using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00216

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00216", "FormName");
		//Fields


        public static WinFormsField WarningMessageLine = new WinFormsField("WARNING-MESSAGE-LINE", "WarningMessageLine");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
