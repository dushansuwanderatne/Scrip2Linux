using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS17502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS17502", "FormName");
		//Fields


        public static WinFormsField InputFileName = new WinFormsField("INPUT-FILE-NAME", "InputFileName");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
    }
}
