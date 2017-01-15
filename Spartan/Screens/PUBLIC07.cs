using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PUBLIC07

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PUBLIC07", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField LN = new WinFormsField("LN", "LN");
        public static WinFormsField N1 = new WinFormsField("N1", "N1");
        public static WinFormsField N2 = new WinFormsField("N2", "N2");
        public static WinFormsField PC = new WinFormsField("PC", "PC");
        public static WinFormsField Dfs = new WinFormsField("DFS", "Dfs");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
