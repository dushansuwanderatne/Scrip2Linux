using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SSBG0106

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SSBG0106", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField AcceptanceClass = new WinFormsField("ACCEPTANCE-CLASS", "AcceptanceClass");
        public static WinFormsField AcceptancePrice = new WinFormsField("ACCEPTANCE-PRICE", "AcceptancePrice");
        public static WinFormsField MarketPrice = new WinFormsField("MARKET-PRICE", "MarketPrice");
        public static WinFormsField MinimumDeposit = new WinFormsField("MINIMUM-DEPOSIT", "MinimumDeposit");
        public static WinFormsField AdditionalClass = new WinFormsField("ADDITIONAL-CLASS", "AdditionalClass");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
        public static WinFormsField FormsOption = new WinFormsField("FORMS-OPTION", "FormsOption");
        public static WinFormsField ReportSequence = new WinFormsField("REPORT-SEQUENCE", "ReportSequence");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
