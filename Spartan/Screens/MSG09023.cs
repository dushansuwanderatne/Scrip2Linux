using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG09023

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG09023", "FormName");
		//Fields


        public static WinFormsField ForwardUser = new WinFormsField("FORWARD-USER", "ForwardUser");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
