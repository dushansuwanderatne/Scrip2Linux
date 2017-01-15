using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS56

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS56", "FormName");
		//Fields
        public static WinFormsField ClassCodeParm = new WinFormsField("CLASS-CODE-PARM", "ClassCodeParm");
        public static WinFormsField FinYearParm = new WinFormsField("FIN-YEAR-PARM", "FinYearParm");
        public static WinFormsField DsptchRunsOnlyInd = new WinFormsField("DSPTCH-RUNS-ONLY-IND", "DsptchRunsOnlyInd");
        public static WinFormsField DetailLine = new WinFormsField("DETAIL-LINE", "DetailLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
