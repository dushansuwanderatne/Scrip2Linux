using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01037

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01037", "FormName");
		//Fields
        public static WinFormsField TrancheNbr = new WinFormsField("TRANCHE-NBR", "TrancheNbr");
        public static WinFormsField TestNbr = new WinFormsField("TEST-NBR", "TestNbr");
        public static WinFormsField VstDesc = new WinFormsField("VST-DESC", "VstDesc");
        public static WinFormsField VstTerm = new WinFormsField("VST-TERM", "VstTerm");
        public static WinFormsField UnitRnd = new WinFormsField("UNIT-RND", "UnitRnd");
        public static WinFormsField VstComments = new WinFormsField("VST-COMMENTS", "VstComments");
        public static WinFormsField PeriodFRVstStart = new WinFormsField("PERIOD-FR-VST-START", "PeriodFRVstStart");
        public static WinFormsField VestPerc = new WinFormsField("VEST-PERC", "VestPerc");
        public static WinFormsField VestDate = new WinFormsField("VEST-DATE", "VestDate");
        public static WinFormsField PerformanceDesc = new WinFormsField("PERFORMANCE-DESC", "PerformanceDesc");
        public static WinFormsField TestDate = new WinFormsField("TEST-DATE", "TestDate");
        public static WinFormsField TestPerc = new WinFormsField("TEST-PERC", "TestPerc");
        public static WinFormsField CancUnvest = new WinFormsField("CANC-UNVEST", "CancUnvest");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
