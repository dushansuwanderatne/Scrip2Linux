using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB04WN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB04WN", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField OverridePrice = new WinFormsField("OVERRIDE-PRICE", "OverridePrice");
    }
}
