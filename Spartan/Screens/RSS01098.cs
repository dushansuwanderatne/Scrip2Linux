using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS01098

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS01098", "FormName");
		//Fields


        public static WinFormsField XtrName = new WinFormsField("XTR-NAME", "XtrName");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
