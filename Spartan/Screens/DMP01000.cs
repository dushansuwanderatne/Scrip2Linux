using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01000", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
