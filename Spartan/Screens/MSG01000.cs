using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01000", "FormName");
		//Fields
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
