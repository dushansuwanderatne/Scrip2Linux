using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class GETRUN00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("GETRUN00", "FormName");
		//Fields


        public static WinFormsField InputDate = new WinFormsField("INPUT-DATE", "InputDate");
    }
}
