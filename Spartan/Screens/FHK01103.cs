using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01103", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDescription = new WinFormsField("ISSUE-DESCRIPTION", "IssueDescription");
        public static WinFormsField OpenDate = new WinFormsField("OPEN-DATE", "OpenDate");
        public static WinFormsField CloseDate = new WinFormsField("CLOSE-DATE", "CloseDate");
        public static WinFormsField FirstPaymentDate = new WinFormsField("FIRST-PAYMENT-DATE", "FirstPaymentDate");
        public static WinFormsField PayATEndOFMonth = new WinFormsField("PAY-AT-END-OF-MONTH", "PayATEndOFMonth");
        public static WinFormsField PartialInstalmntInd = new WinFormsField("PARTIAL-INSTALMNT-IND", "PartialInstalmntInd");
        public static WinFormsField CalculateAccruedInd = new WinFormsField("CALCULATE-ACCRUED-IND", "CalculateAccruedInd");
        public static WinFormsField AccruedTradingOpt = new WinFormsField("ACCRUED-TRADING-OPT", "AccruedTradingOpt");
        public static WinFormsField AccruedCalcOption = new WinFormsField("ACCRUED-CALC-OPTION", "AccruedCalcOption");
        public static WinFormsField AccruedRoundOption = new WinFormsField("ACCRUED-ROUND-OPTION", "AccruedRoundOption");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
