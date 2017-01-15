using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1012

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1012", "FormName");
		//Fields
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField BrokenPeriod = new WinFormsField("BROKEN-PERIOD", "BrokenPeriod");
        public static WinFormsField UnitDayCalc = new WinFormsField("UNIT-DAY-CALC", "UnitDayCalc");
        public static WinFormsField UnitDayStartPeriod = new WinFormsField("UNIT-DAY-START-PERIOD", "UnitDayStartPeriod");
        public static WinFormsField UnitDayCertZero = new WinFormsField("UNIT-DAY-CERT-ZERO", "UnitDayCertZero");
        public static WinFormsField AtoEftLgePayApply = new WinFormsField("ATO-EFT-LGE-PAY-APPLY", "AtoEftLgePayApply");
        public static WinFormsField DividendSourceApply = new WinFormsField("DIVIDEND-SOURCE-APPLY", "DividendSourceApply");
        public static WinFormsField CharityElectApply = new WinFormsField("CHARITY-ELECT-APPLY", "CharityElectApply");
        public static WinFormsField DividendPlanApply = new WinFormsField("DIVIDEND-PLAN-APPLY", "DividendPlanApply");
        public static WinFormsField Selcat = new WinFormsField("SELCAT", "Selcat");
        public static WinFormsField DividendPlan = new WinFormsField("DIVIDEND-PLAN", "DividendPlan");
        public static WinFormsField PlanHolderID = new WinFormsField("PLAN-HOLDER-ID", "PlanHolderID");
        public static WinFormsField DrpPrefOverBspInd = new WinFormsField("DRP-PREF-OVER-BSP-IND", "DrpPrefOverBspInd");
        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField Rptcls = new WinFormsField("RPTCLS", "Rptcls");
        public static WinFormsField Selreg1 = new WinFormsField("SELREG-1", "Selreg1");
        public static WinFormsField Selreg2 = new WinFormsField("SELREG-2", "Selreg2");
        public static WinFormsField RegList = new WinFormsField("REG-LIST", "RegList");
        public static WinFormsField HidTOPrint = new WinFormsField("HID-TO-PRINT", "HidTOPrint");
        public static WinFormsField DeferBuild = new WinFormsField("DEFER-BUILD", "DeferBuild");
        public static WinFormsField BuildDeferDate = new WinFormsField("BUILD-DEFER-DATE", "BuildDeferDate");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField EomSelectionCode = new WinFormsField("EOM-SELECTION-CODE", "EomSelectionCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
