using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS16060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS16060", "FormName");
		//Fields


        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
    }
}
