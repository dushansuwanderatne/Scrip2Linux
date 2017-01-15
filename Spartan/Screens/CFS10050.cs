using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10050", "FormName");
		//Fields


        public static WinFormsField Coy = new WinFormsField("COY", "Coy");
        public static WinFormsField Error = new WinFormsField("ERROR", "Error");
        public static WinFormsField Return = new WinFormsField("RETURN", "Return");
    }
}
