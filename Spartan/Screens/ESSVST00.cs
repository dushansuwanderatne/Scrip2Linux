using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSVST00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSVST00", "FormName");
		//Fields


        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField TrancheNumber = new WinFormsField("TRANCHE-NUMBER", "TrancheNumber");
        public static WinFormsField PerformanceCode = new WinFormsField("PERFORMANCE-CODE", "PerformanceCode");
        public static WinFormsField TestNumber = new WinFormsField("TEST-NUMBER", "TestNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
