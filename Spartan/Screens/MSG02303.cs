using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02303

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02303", "FormName");
		//Fields


        public static WinFormsField NotDel1 = new WinFormsField("NOT-DEL-1", "NotDel1");
        public static WinFormsField NotDel2 = new WinFormsField("NOT-DEL-2", "NotDel2");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
