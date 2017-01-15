using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG09002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG09002", "FormName");
		//Fields


        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField AddName = new WinFormsField("ADD-NAME", "AddName");
    }
}
