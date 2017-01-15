using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEYT0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEYT0101", "FormName");
		//Fields


        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField ReportDesc = new WinFormsField("REPORT-DESC", "ReportDesc");
        public static WinFormsField EytStage = new WinFormsField("EYT-STAGE", "EytStage");
        public static WinFormsField AddText = new WinFormsField("ADD-TEXT", "AddText");
        public static WinFormsField AddDesc = new WinFormsField("ADD-DESC", "AddDesc");
        public static WinFormsField MoreText = new WinFormsField("MORE-TEXT", "MoreText");
        public static WinFormsField MoreDesc = new WinFormsField("MORE-DESC", "MoreDesc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
