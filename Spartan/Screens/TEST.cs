using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TEST

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TEST", "FormName");
		//Fields


        public static WinFormsField Field1 = new WinFormsField("FIELD1", "Field1");
    }
}
