using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS05001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS05001", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField EffectiveFromDate = new WinFormsField("EFFECTIVE-FROM-DATE", "EffectiveFromDate");
        public static WinFormsField MerPercentage = new WinFormsField("MER-PERCENTAGE", "MerPercentage");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LitAdd = new WinFormsField("LIT-ADD", "LitAdd");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField FilterClass = new WinFormsField("FILTER-CLASS", "FilterClass");
        public static WinFormsField StartFromMths = new WinFormsField("START-FROM-MTHS", "StartFromMths");
        public static WinFormsField StartFromYrs = new WinFormsField("START-FROM-YRS", "StartFromYrs");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
