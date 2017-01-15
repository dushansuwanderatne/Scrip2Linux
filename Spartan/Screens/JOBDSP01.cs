using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBDSP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBDSP01", "FormName");
		//Fields


        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
