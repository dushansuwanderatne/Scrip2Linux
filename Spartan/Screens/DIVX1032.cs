using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1032

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1032", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField SourceDescription = new WinFormsField("SOURCE-DESCRIPTION", "SourceDescription");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField SubPayCode = new WinFormsField("SUB-PAY-CODE", "SubPayCode");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField TypeDescription = new WinFormsField("TYPE-DESCRIPTION", "TypeDescription");
        public static WinFormsField ClassCat = new WinFormsField("CLASS-CAT", "ClassCat");
        public static WinFormsField TotUnits = new WinFormsField("TOT-UNITS", "TotUnits");
        public static WinFormsField ParValue = new WinFormsField("PAR-VALUE", "ParValue");
        public static WinFormsField InterestPercentage = new WinFormsField("INTEREST-PERCENTAGE", "InterestPercentage");
        public static WinFormsField InterestPeriod = new WinFormsField("INTEREST-PERIOD", "InterestPeriod");
        public static WinFormsField IntNumberOFDays = new WinFormsField("INT-NUMBER-OF-DAYS", "IntNumberOFDays");
        public static WinFormsField RateDescription = new WinFormsField("RATE-DESCRIPTION", "RateDescription");
        public static WinFormsField CalcTotDistAmount = new WinFormsField("CALC-TOT-DIST-AMOUNT", "CalcTotDistAmount");
        public static WinFormsField CalcDistUnitRate = new WinFormsField("CALC-DIST-UNIT-RATE", "CalcDistUnitRate");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
