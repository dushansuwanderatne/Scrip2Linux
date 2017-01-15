using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS05000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS05000", "FormName");
		//Fields


        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField JulianDate = new WinFormsField("JULIAN-DATE", "JulianDate");
        public static WinFormsField Origin1to13 = new WinFormsField("ORIGIN-1TO13", "Origin1to13");
        public static WinFormsField Origin14to26 = new WinFormsField("ORIGIN-14TO26", "Origin14to26");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchDate = new WinFormsField("SEARCH-DATE", "SearchDate");
    }
}
