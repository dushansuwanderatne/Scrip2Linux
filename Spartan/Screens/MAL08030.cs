using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL08030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL08030", "FormName");
		//Fields


        public static WinFormsField Companies1 = new WinFormsField("COMPANIES-1", "Companies1");
        public static WinFormsField Companies2 = new WinFormsField("COMPANIES-2", "Companies2");
        public static WinFormsField Groups1 = new WinFormsField("GROUPS-1", "Groups1");
        public static WinFormsField Groups2 = new WinFormsField("GROUPS-2", "Groups2");
        public static WinFormsField DumpCriteria = new WinFormsField("DUMP-CRITERIA", "DumpCriteria");
    }
}
