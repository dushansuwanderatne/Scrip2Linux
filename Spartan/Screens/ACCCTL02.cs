using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCCTL02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCCTL02", "FormName");
		//Fields


        public static WinFormsField AccctlKey0 = new WinFormsField("ACCCTL-KEY0", "AccctlKey0");
        public static WinFormsField AdditionalClass = new WinFormsField("ADDITIONAL-CLASS", "AdditionalClass");
        public static WinFormsField AdditionalMoneyClass = new WinFormsField("ADDITIONAL-MONEY-CLASS", "AdditionalMoneyClass");
        public static WinFormsField AdnToleranceApplyInd = new WinFormsField("ADN-TOLERANCE-APPLY-IND", "AdnToleranceApplyInd");
        public static WinFormsField OPriceKnownInd = new WinFormsField("O-PRICE-KNOWN-IND", "OPriceKnownInd");
        public static WinFormsField OAcceptanceMinimum = new WinFormsField("O-ACCEPTANCE-MINIMUM", "OAcceptanceMinimum");
        public static WinFormsField OAccLvlCalType = new WinFormsField("O-ACC-LVL-CAL-TYPE", "OAccLvlCalType");
        public static WinFormsField OUnitPrice = new WinFormsField("O-UNIT-PRICE", "OUnitPrice");
        public static WinFormsField OAcceptanceMultiple = new WinFormsField("O-ACCEPTANCE-MULTIPLE", "OAcceptanceMultiple");
        public static WinFormsField OToleranceAmount = new WinFormsField("O-TOLERANCE-AMOUNT", "OToleranceAmount");
        public static WinFormsField OAcceptanceMaximum = new WinFormsField("O-ACCEPTANCE-MAXIMUM", "OAcceptanceMaximum");
        public static WinFormsField OAcceptanceLvlMoney1 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-1", "OAcceptanceLvlMoney1");
        public static WinFormsField OAcceptanceLvlUnits1 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-1", "OAcceptanceLvlUnits1");
        public static WinFormsField OCostOFUnits1 = new WinFormsField("O-COST-OF-UNITS-1", "OCostOFUnits1");
        public static WinFormsField OAcceptanceLvlMoney10 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-10", "OAcceptanceLvlMoney10");
        public static WinFormsField OAcceptanceLvlUnits10 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-10", "OAcceptanceLvlUnits10");
        public static WinFormsField OCostOFUnits10 = new WinFormsField("O-COST-OF-UNITS-10", "OCostOFUnits10");
        public static WinFormsField OAcceptanceLvlMoney2 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-2", "OAcceptanceLvlMoney2");
        public static WinFormsField OAcceptanceLvlUnits2 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-2", "OAcceptanceLvlUnits2");
        public static WinFormsField OCostOFUnits2 = new WinFormsField("O-COST-OF-UNITS-2", "OCostOFUnits2");
        public static WinFormsField OAcceptanceLvlMoney11 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-11", "OAcceptanceLvlMoney11");
        public static WinFormsField OAcceptanceLvlUnits11 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-11", "OAcceptanceLvlUnits11");
        public static WinFormsField OCostOFUnits11 = new WinFormsField("O-COST-OF-UNITS-11", "OCostOFUnits11");
        public static WinFormsField OAcceptanceLvlMoney3 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-3", "OAcceptanceLvlMoney3");
        public static WinFormsField OAcceptanceLvlUnits3 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-3", "OAcceptanceLvlUnits3");
        public static WinFormsField OCostOFUnits3 = new WinFormsField("O-COST-OF-UNITS-3", "OCostOFUnits3");
        public static WinFormsField OAcceptanceLvlMoney12 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-12", "OAcceptanceLvlMoney12");
        public static WinFormsField OAcceptanceLvlUnits12 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-12", "OAcceptanceLvlUnits12");
        public static WinFormsField OCostOFUnits12 = new WinFormsField("O-COST-OF-UNITS-12", "OCostOFUnits12");
        public static WinFormsField OAcceptanceLvlMoney4 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-4", "OAcceptanceLvlMoney4");
        public static WinFormsField OAcceptanceLvlUnits4 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-4", "OAcceptanceLvlUnits4");
        public static WinFormsField OCostOFUnits4 = new WinFormsField("O-COST-OF-UNITS-4", "OCostOFUnits4");
        public static WinFormsField OAcceptanceLvlMoney13 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-13", "OAcceptanceLvlMoney13");
        public static WinFormsField OAcceptanceLvlUnits13 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-13", "OAcceptanceLvlUnits13");
        public static WinFormsField OCostOFUnits13 = new WinFormsField("O-COST-OF-UNITS-13", "OCostOFUnits13");
        public static WinFormsField OAcceptanceLvlMoney5 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-5", "OAcceptanceLvlMoney5");
        public static WinFormsField OAcceptanceLvlUnits5 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-5", "OAcceptanceLvlUnits5");
        public static WinFormsField OCostOFUnits5 = new WinFormsField("O-COST-OF-UNITS-5", "OCostOFUnits5");
        public static WinFormsField OAcceptanceLvlMoney14 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-14", "OAcceptanceLvlMoney14");
        public static WinFormsField OAcceptanceLvlUnits14 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-14", "OAcceptanceLvlUnits14");
        public static WinFormsField OCostOFUnits14 = new WinFormsField("O-COST-OF-UNITS-14", "OCostOFUnits14");
        public static WinFormsField OAcceptanceLvlMoney6 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-6", "OAcceptanceLvlMoney6");
        public static WinFormsField OAcceptanceLvlUnits6 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-6", "OAcceptanceLvlUnits6");
        public static WinFormsField OCostOFUnits6 = new WinFormsField("O-COST-OF-UNITS-6", "OCostOFUnits6");
        public static WinFormsField OAcceptanceLvlMoney15 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-15", "OAcceptanceLvlMoney15");
        public static WinFormsField OAcceptanceLvlUnits15 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-15", "OAcceptanceLvlUnits15");
        public static WinFormsField OCostOFUnits15 = new WinFormsField("O-COST-OF-UNITS-15", "OCostOFUnits15");
        public static WinFormsField OAcceptanceLvlMoney7 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-7", "OAcceptanceLvlMoney7");
        public static WinFormsField OAcceptanceLvlUnits7 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-7", "OAcceptanceLvlUnits7");
        public static WinFormsField OCostOFUnits7 = new WinFormsField("O-COST-OF-UNITS-7", "OCostOFUnits7");
        public static WinFormsField OAcceptanceLvlMoney16 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-16", "OAcceptanceLvlMoney16");
        public static WinFormsField OAcceptanceLvlUnits16 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-16", "OAcceptanceLvlUnits16");
        public static WinFormsField OCostOFUnits16 = new WinFormsField("O-COST-OF-UNITS-16", "OCostOFUnits16");
        public static WinFormsField OAcceptanceLvlMoney8 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-8", "OAcceptanceLvlMoney8");
        public static WinFormsField OAcceptanceLvlUnits8 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-8", "OAcceptanceLvlUnits8");
        public static WinFormsField OCostOFUnits8 = new WinFormsField("O-COST-OF-UNITS-8", "OCostOFUnits8");
        public static WinFormsField OAcceptanceLvlMoney17 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-17", "OAcceptanceLvlMoney17");
        public static WinFormsField OAcceptanceLvlUnits17 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-17", "OAcceptanceLvlUnits17");
        public static WinFormsField OCostOFUnits17 = new WinFormsField("O-COST-OF-UNITS-17", "OCostOFUnits17");
        public static WinFormsField OAcceptanceLvlMoney9 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-9", "OAcceptanceLvlMoney9");
        public static WinFormsField OAcceptanceLvlUnits9 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-9", "OAcceptanceLvlUnits9");
        public static WinFormsField OCostOFUnits9 = new WinFormsField("O-COST-OF-UNITS-9", "OCostOFUnits9");
        public static WinFormsField OAcceptanceLvlMoney18 = new WinFormsField("O-ACCEPTANCE-LVL-MONEY-18", "OAcceptanceLvlMoney18");
        public static WinFormsField OAcceptanceLvlUnits18 = new WinFormsField("O-ACCEPTANCE-LVL-UNITS-18", "OAcceptanceLvlUnits18");
        public static WinFormsField OCostOFUnits18 = new WinFormsField("O-COST-OF-UNITS-18", "OCostOFUnits18");
    }
}
