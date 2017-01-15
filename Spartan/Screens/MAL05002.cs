using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL05002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL05002", "FormName");
		//Fields


        public static WinFormsField DateAdded = new WinFormsField("DATE-ADDED", "DateAdded");
        public static WinFormsField DateLastChanged = new WinFormsField("DATE-LAST-CHANGED", "DateLastChanged");
        public static WinFormsField RunLastChanged = new WinFormsField("RUN-LAST-CHANGED", "RunLastChanged");
    }
}
