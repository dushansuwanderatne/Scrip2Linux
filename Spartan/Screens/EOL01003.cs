using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01003", "FormName");
		//Fields


        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
        public static WinFormsField PendingUnits = new WinFormsField("PENDING-UNITS", "PendingUnits");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
