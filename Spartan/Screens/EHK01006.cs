using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01006", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField TaxReportableInd = new WinFormsField("TAX-REPORTABLE-IND", "TaxReportableInd");
        public static WinFormsField ExpiresAfterMonths = new WinFormsField("EXPIRES-AFTER-MONTHS", "ExpiresAfterMonths");
        public static WinFormsField ExpiresAfterDays = new WinFormsField("EXPIRES-AFTER-DAYS", "ExpiresAfterDays");
        public static WinFormsField LeaverSchedule = new WinFormsField("LEAVER-SCHEDULE", "LeaverSchedule");
        public static WinFormsField UsingVestingInd = new WinFormsField("USING-VESTING-IND", "UsingVestingInd");
        public static WinFormsField UnitRounding = new WinFormsField("UNIT-ROUNDING", "UnitRounding");
        public static WinFormsField MoneyRounding = new WinFormsField("MONEY-ROUNDING", "MoneyRounding");
        public static WinFormsField ReleaseOption = new WinFormsField("RELEASE-OPTION", "ReleaseOption");
        public static WinFormsField CalculateTaxInd = new WinFormsField("CALCULATE-TAX-IND", "CalculateTaxInd");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField FinRptExp = new WinFormsField("FIN-RPT-EXP", "FinRptExp");
        public static WinFormsField MinMaxType = new WinFormsField("MIN-MAX-TYPE", "MinMaxType");
        public static WinFormsField MinMoneyAmt = new WinFormsField("MIN-MONEY-AMT", "MinMoneyAmt");
        public static WinFormsField MaxMoneyAmt = new WinFormsField("MAX-MONEY-AMT", "MaxMoneyAmt");
        public static WinFormsField FreeFormatLine = new WinFormsField("FREE-FORMAT-LINE", "FreeFormatLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgumentReg = new WinFormsField("LOCATE-ARGUMENT-REG", "LocateArgumentReg");
        public static WinFormsField LocateArgumentType = new WinFormsField("LOCATE-ARGUMENT-TYPE", "LocateArgumentType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
