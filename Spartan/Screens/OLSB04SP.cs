using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB04SP

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB04SP", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SplitNumber = new WinFormsField("SPLIT-NUMBER", "SplitNumber");
        public static WinFormsField SplitUnits = new WinFormsField("SPLIT-UNITS", "SplitUnits");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
    }
}
