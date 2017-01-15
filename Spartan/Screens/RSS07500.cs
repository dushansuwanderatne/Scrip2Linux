using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS07500
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS07500", "FormName");
        //Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PlanSelection = new WinFormsField("PLAN-SELECTION", "PlanSelection");
        public static WinFormsField PlanPartType = new WinFormsField("PLAN-PART-TYPE", "PlanPartType");
        public static WinFormsField BalanceSelection = new WinFormsField("BALANCE-SELECTION", "BalanceSelection");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField ExtractFilename = new WinFormsField("EXTRACT-FILENAME", "ExtractFilename");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
