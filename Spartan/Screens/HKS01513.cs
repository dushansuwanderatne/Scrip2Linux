using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01513

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01513", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField WeeklyStmtLine = new WinFormsField("WEEKLY-STMT-LINE", "WeeklyStmtLine");
        public static WinFormsField SixMthStmtLine = new WinFormsField("SIX-MTH-STMT-LINE", "SixMthStmtLine");
        public static WinFormsField SpecStatProg = new WinFormsField("SPEC-STAT-PROG", "SpecStatProg");
        public static WinFormsField WeeklyStmtRun1 = new WinFormsField("WEEKLY-STMT-RUN1", "WeeklyStmtRun1");
        public static WinFormsField WeeklyStmtRun2 = new WinFormsField("WEEKLY-STMT-RUN2", "WeeklyStmtRun2");
        public static WinFormsField SixMthStmtRun1 = new WinFormsField("SIX-MTH-STMT-RUN1", "SixMthStmtRun1");
        public static WinFormsField SixMthStmtRun2 = new WinFormsField("SIX-MTH-STMT-RUN2", "SixMthStmtRun2");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
