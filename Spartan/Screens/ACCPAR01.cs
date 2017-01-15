using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCPAR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCPAR01", "FormName");
		//Fields


        public static WinFormsField ActiveDateFrom = new WinFormsField("ACTIVE-DATE-FROM", "ActiveDateFrom");
        public static WinFormsField ActiveDateTO = new WinFormsField("ACTIVE-DATE-TO", "ActiveDateTO");
        public static WinFormsField RemProcessEndDate = new WinFormsField("REM-PROCESS-END-DATE", "RemProcessEndDate");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField ReceiptRoutingID = new WinFormsField("RECEIPT-ROUTING-ID", "ReceiptRoutingID");
        public static WinFormsField UnitPrice = new WinFormsField("UNIT-PRICE", "UnitPrice");
        public static WinFormsField PriceKnownInd = new WinFormsField("PRICE-KNOWN-IND", "PriceKnownInd");
        public static WinFormsField ToleranceAmount = new WinFormsField("TOLERANCE-AMOUNT", "ToleranceAmount");
        public static WinFormsField TranTypeIndicator = new WinFormsField("TRAN-TYPE-INDICATOR", "TranTypeIndicator");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField EntitlementClass = new WinFormsField("ENTITLEMENT-CLASS", "EntitlementClass");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField AcceptanceClass = new WinFormsField("ACCEPTANCE-CLASS", "AcceptanceClass");
        public static WinFormsField UnallocatedHolderID = new WinFormsField("UNALLOCATED-HOLDER-ID", "UnallocatedHolderID");
        public static WinFormsField OverrideUnitClass = new WinFormsField("OVERRIDE-UNIT-CLASS", "OverrideUnitClass");
        public static WinFormsField AdditionalClass = new WinFormsField("ADDITIONAL-CLASS", "AdditionalClass");
        public static WinFormsField AdnUnitPrice = new WinFormsField("ADN-UNIT-PRICE", "AdnUnitPrice");
        public static WinFormsField AdditionalMnyClass = new WinFormsField("ADDITIONAL-MNY-CLASS", "AdditionalMnyClass");
        public static WinFormsField AdnToleranceApply = new WinFormsField("ADN-TOLERANCE-APPLY", "AdnToleranceApply");
        public static WinFormsField AccLvlCalType1 = new WinFormsField("ACC-LVL-CAL-TYPE-1", "AccLvlCalType1");
        public static WinFormsField AccLvlCalType2 = new WinFormsField("ACC-LVL-CAL-TYPE-2", "AccLvlCalType2");
        public static WinFormsField AcceptanceMinimum = new WinFormsField("ACCEPTANCE-MINIMUM", "AcceptanceMinimum");
        public static WinFormsField AcceptanceMultiple = new WinFormsField("ACCEPTANCE-MULTIPLE", "AcceptanceMultiple");
        public static WinFormsField AcceptanceMaximum = new WinFormsField("ACCEPTANCE-MAXIMUM", "AcceptanceMaximum");
        public static WinFormsField AcceptanceMoney1 = new WinFormsField("ACCEPTANCE-MONEY-1", "AcceptanceMoney1");
        public static WinFormsField AcceptanceUnit1 = new WinFormsField("ACCEPTANCE-UNIT-1", "AcceptanceUnit1");
        public static WinFormsField AcceptanceMoney2 = new WinFormsField("ACCEPTANCE-MONEY-2", "AcceptanceMoney2");
        public static WinFormsField AcceptanceUnit2 = new WinFormsField("ACCEPTANCE-UNIT-2", "AcceptanceUnit2");
        public static WinFormsField AcceptanceMoney3 = new WinFormsField("ACCEPTANCE-MONEY-3", "AcceptanceMoney3");
        public static WinFormsField AcceptanceUnit3 = new WinFormsField("ACCEPTANCE-UNIT-3", "AcceptanceUnit3");
        public static WinFormsField AcceptanceMoney4 = new WinFormsField("ACCEPTANCE-MONEY-4", "AcceptanceMoney4");
        public static WinFormsField AcceptanceUnit4 = new WinFormsField("ACCEPTANCE-UNIT-4", "AcceptanceUnit4");
        public static WinFormsField AcceptanceMoney5 = new WinFormsField("ACCEPTANCE-MONEY-5", "AcceptanceMoney5");
        public static WinFormsField AcceptanceUnit5 = new WinFormsField("ACCEPTANCE-UNIT-5", "AcceptanceUnit5");
        public static WinFormsField AcceptanceMoney6 = new WinFormsField("ACCEPTANCE-MONEY-6", "AcceptanceMoney6");
        public static WinFormsField AcceptanceUnit6 = new WinFormsField("ACCEPTANCE-UNIT-6", "AcceptanceUnit6");
        public static WinFormsField AcceptanceMoney7 = new WinFormsField("ACCEPTANCE-MONEY-7", "AcceptanceMoney7");
        public static WinFormsField AcceptanceUnit7 = new WinFormsField("ACCEPTANCE-UNIT-7", "AcceptanceUnit7");
        public static WinFormsField AcceptanceMoney8 = new WinFormsField("ACCEPTANCE-MONEY-8", "AcceptanceMoney8");
        public static WinFormsField AcceptanceUnit8 = new WinFormsField("ACCEPTANCE-UNIT-8", "AcceptanceUnit8");
        public static WinFormsField AcceptanceMoney9 = new WinFormsField("ACCEPTANCE-MONEY-9", "AcceptanceMoney9");
        public static WinFormsField AcceptanceUnit9 = new WinFormsField("ACCEPTANCE-UNIT-9", "AcceptanceUnit9");
        public static WinFormsField AcceptanceMoney10 = new WinFormsField("ACCEPTANCE-MONEY-10", "AcceptanceMoney10");
        public static WinFormsField AcceptanceUnit10 = new WinFormsField("ACCEPTANCE-UNIT-10", "AcceptanceUnit10");
        public static WinFormsField AcceptanceMoney11 = new WinFormsField("ACCEPTANCE-MONEY-11", "AcceptanceMoney11");
        public static WinFormsField AcceptanceUnit11 = new WinFormsField("ACCEPTANCE-UNIT-11", "AcceptanceUnit11");
        public static WinFormsField AcceptanceMoney12 = new WinFormsField("ACCEPTANCE-MONEY-12", "AcceptanceMoney12");
        public static WinFormsField AcceptanceUnit12 = new WinFormsField("ACCEPTANCE-UNIT-12", "AcceptanceUnit12");
        public static WinFormsField AcceptanceMoney13 = new WinFormsField("ACCEPTANCE-MONEY-13", "AcceptanceMoney13");
        public static WinFormsField AcceptanceUnit13 = new WinFormsField("ACCEPTANCE-UNIT-13", "AcceptanceUnit13");
        public static WinFormsField AcceptanceMoney14 = new WinFormsField("ACCEPTANCE-MONEY-14", "AcceptanceMoney14");
        public static WinFormsField AcceptanceUnit14 = new WinFormsField("ACCEPTANCE-UNIT-14", "AcceptanceUnit14");
        public static WinFormsField AcceptanceMoney15 = new WinFormsField("ACCEPTANCE-MONEY-15", "AcceptanceMoney15");
        public static WinFormsField AcceptanceUnit15 = new WinFormsField("ACCEPTANCE-UNIT-15", "AcceptanceUnit15");
        public static WinFormsField AcceptanceMoney16 = new WinFormsField("ACCEPTANCE-MONEY-16", "AcceptanceMoney16");
        public static WinFormsField AcceptanceUnit16 = new WinFormsField("ACCEPTANCE-UNIT-16", "AcceptanceUnit16");
        public static WinFormsField AcceptanceMoney17 = new WinFormsField("ACCEPTANCE-MONEY-17", "AcceptanceMoney17");
        public static WinFormsField AcceptanceUnit17 = new WinFormsField("ACCEPTANCE-UNIT-17", "AcceptanceUnit17");
        public static WinFormsField AcceptanceMoney18 = new WinFormsField("ACCEPTANCE-MONEY-18", "AcceptanceMoney18");
        public static WinFormsField AcceptanceUnit18 = new WinFormsField("ACCEPTANCE-UNIT-18", "AcceptanceUnit18");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
