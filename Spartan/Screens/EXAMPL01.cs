using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EXAMPL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EXAMPL01", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
    }
}
