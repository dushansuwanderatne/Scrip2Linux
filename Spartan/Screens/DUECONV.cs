using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DUECONV

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DUECONV", "FormName");
		//Fields


        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}