using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03702", "FormName");
		//Fields


        public static WinFormsField HRSource = new WinFormsField("HR-SOURCE", "HRSource");
        public static WinFormsField HRSourceDesc = new WinFormsField("HR-SOURCE-DESC", "HRSourceDesc");
        public static WinFormsField ScripFieldID = new WinFormsField("SCRIP-FIELD-ID", "ScripFieldID");
        public static WinFormsField ScripFieldDesc = new WinFormsField("SCRIP-FIELD-DESC", "ScripFieldDesc");
        public static WinFormsField MappingRuleDesc = new WinFormsField("MAPPING-RULE-DESC", "MappingRuleDesc");
        public static WinFormsField MappingValue = new WinFormsField("MAPPING-VALUE", "MappingValue");
        public static WinFormsField ScripValue = new WinFormsField("SCRIP-VALUE", "ScripValue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1 = new WinFormsField("ACTION-1", "Action1");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
