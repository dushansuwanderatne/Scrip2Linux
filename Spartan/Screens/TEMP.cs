using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TEMP

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TEMP", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}