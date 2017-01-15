using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AllotListHeading = new WinFormsField("ALLOT-LIST-HEADING", "AllotListHeading");
        public static WinFormsField ProcessAfterRun = new WinFormsField("PROCESS-AFTER-RUN", "ProcessAfterRun");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField AllotmentDate = new WinFormsField("ALLOTMENT-DATE", "AllotmentDate");
        public static WinFormsField RequireDividend = new WinFormsField("REQUIRE-DIVIDEND", "RequireDividend");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField TranTypeIndicator = new WinFormsField("TRAN-TYPE-INDICATOR", "TranTypeIndicator");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
