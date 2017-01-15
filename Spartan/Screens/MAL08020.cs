using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL08020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL08020", "FormName");
		//Fields


        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
