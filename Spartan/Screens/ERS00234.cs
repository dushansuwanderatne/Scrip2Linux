using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00234

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00234", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportClass = new WinFormsField("REPORT-CLASS", "ReportClass");
        public static WinFormsField DepONDate = new WinFormsField("DEP-ON-DATE", "DepONDate");
        public static WinFormsField MarketPrice = new WinFormsField("MARKET-PRICE", "MarketPrice");
        public static WinFormsField TrusteeDepONDate = new WinFormsField("TRUSTEE-DEP-ON-DATE", "TrusteeDepONDate");
        public static WinFormsField TrusteePrice = new WinFormsField("TRUSTEE-PRICE", "TrusteePrice");
        public static WinFormsField CutoffRunNO = new WinFormsField("CUTOFF-RUN-NO", "CutoffRunNO");
        public static WinFormsField StampDutyBrokerage = new WinFormsField("STAMP-DUTY-BROKERAGE", "StampDutyBrokerage");
        public static WinFormsField ReduceTOZero = new WinFormsField("REDUCE-TO-ZERO", "ReduceTOZero");
        public static WinFormsField PayCrossClass = new WinFormsField("PAY-CROSS-CLASS", "PayCrossClass");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
