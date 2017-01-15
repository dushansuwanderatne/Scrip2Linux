using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTMT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTMT", "FormName");
		//Fields


        public static WinFormsField Multiple = new WinFormsField("MULTIPLE", "Multiple");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
