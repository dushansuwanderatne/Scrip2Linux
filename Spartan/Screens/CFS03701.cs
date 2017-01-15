using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03701", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField AiirReference = new WinFormsField("AIIR-REFERENCE", "AiirReference");
        public static WinFormsField FinYearStart = new WinFormsField("FIN-YEAR-START", "FinYearStart");
        public static WinFormsField FinYearEnd = new WinFormsField("FIN-YEAR-END", "FinYearEnd");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LitAdd = new WinFormsField("LIT-ADD", "LitAdd");
        public static WinFormsField LitSearch = new WinFormsField("LIT-SEARCH", "LitSearch");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField SearchReference = new WinFormsField("SEARCH-REFERENCE", "SearchReference");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
