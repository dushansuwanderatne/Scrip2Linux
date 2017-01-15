using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03701", "FormName");
		//Fields


        public static WinFormsField HRSource = new WinFormsField("HR-SOURCE", "HRSource");
        public static WinFormsField HRSourceDesc = new WinFormsField("HR-SOURCE-DESC", "HRSourceDesc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField ScripFieldID = new WinFormsField("SCRIP-FIELD-ID", "ScripFieldID");
        public static WinFormsField MappingRule = new WinFormsField("MAPPING-RULE", "MappingRule");
        public static WinFormsField MappingValue = new WinFormsField("MAPPING-VALUE", "MappingValue");
        public static WinFormsField ScripValue = new WinFormsField("SCRIP-VALUE", "ScripValue");
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
