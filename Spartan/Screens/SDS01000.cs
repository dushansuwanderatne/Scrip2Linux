using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS01000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS01000", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
