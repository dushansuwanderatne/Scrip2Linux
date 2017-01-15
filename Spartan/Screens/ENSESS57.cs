using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS57

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS57", "FormName");
		//Fields


        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField ClassCodeParm = new WinFormsField("CLASS-CODE-PARM", "ClassCodeParm");
        public static WinFormsField FinYearParm = new WinFormsField("FIN-YEAR-PARM", "FinYearParm");
        public static WinFormsField DsptchRunsOnlyInd = new WinFormsField("DSPTCH-RUNS-ONLY-IND", "DsptchRunsOnlyInd");
        public static WinFormsField LineNumber = new WinFormsField("LINE-NUMBER", "LineNumber");
        public static WinFormsField StaticData = new WinFormsField("STATIC-DATA", "StaticData");
        public static WinFormsField UpdatedData = new WinFormsField("UPDATED-DATA", "UpdatedData");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
