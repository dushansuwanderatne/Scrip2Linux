using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EXAMPL03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EXAMPL03", "FormName");
		//Fields


        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
    }
}
