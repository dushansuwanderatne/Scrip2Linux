using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS14001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS14001", "FormName");
		//Fields


        public static WinFormsField ExtractName = new WinFormsField("EXTRACT-NAME", "ExtractName");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
