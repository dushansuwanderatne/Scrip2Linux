using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class WFRMVER

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("WFRMVER", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
