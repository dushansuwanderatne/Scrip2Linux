using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP01", "FormName");
		//Fields


        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}
