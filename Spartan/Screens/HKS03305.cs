using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03305

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03305", "FormName");
		//Fields


        public static WinFormsField XrefDetails = new WinFormsField("XREF-DETAILS", "XrefDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
