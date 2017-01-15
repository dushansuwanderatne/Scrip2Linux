using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPS00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPS00201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField EventNumber = new WinFormsField("EVENT-NUMBER", "EventNumber");
        public static WinFormsField FaxReference = new WinFormsField("FAX-REFERENCE", "FaxReference");
        public static WinFormsField IncomingFileName = new WinFormsField("INCOMING-FILE-NAME", "IncomingFileName");
        public static WinFormsField SubSystem = new WinFormsField("SUB-SYSTEM", "SubSystem");
        public static WinFormsField ExpectedNbrRecs = new WinFormsField("EXPECTED-NBR-RECS", "ExpectedNbrRecs");
        public static WinFormsField ActualNbrRecs = new WinFormsField("ACTUAL-NBR-RECS", "ActualNbrRecs");
        public static WinFormsField ExpectedTotAmt = new WinFormsField("EXPECTED-TOT-AMT", "ExpectedTotAmt");
        public static WinFormsField ActualTotAmt = new WinFormsField("ACTUAL-TOT-AMT", "ActualTotAmt");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField OperatorInitials = new WinFormsField("OPERATOR-INITIALS", "OperatorInitials");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
