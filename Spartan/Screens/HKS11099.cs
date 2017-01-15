using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS11099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS11099", "FormName");
		//Fields


        public static WinFormsField Plan = new WinFormsField("PLAN", "Plan");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
