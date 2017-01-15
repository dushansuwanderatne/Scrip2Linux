using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK06006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK06006", "FormName");
		//Fields


        public static WinFormsField TotalPercentage = new WinFormsField("TOTAL-PERCENTAGE", "TotalPercentage");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
