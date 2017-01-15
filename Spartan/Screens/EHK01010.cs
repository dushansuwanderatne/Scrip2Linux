using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01010", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType1 = new WinFormsField("REGISTER-TYPE-1", "RegisterType1");
        public static WinFormsField RegisterType2 = new WinFormsField("REGISTER-TYPE-2", "RegisterType2");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField StartDateConst = new WinFormsField("START-DATE-CONST", "StartDateConst");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField UnitValueConst = new WinFormsField("UNIT-VALUE-CONST", "UnitValueConst");
        public static WinFormsField UnitValue = new WinFormsField("UNIT-VALUE", "UnitValue");
        public static WinFormsField EndDateConst = new WinFormsField("END-DATE-CONST", "EndDateConst");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField AwardExchangeRate = new WinFormsField("AWARD-EXCHANGE-RATE", "AwardExchangeRate");
        public static WinFormsField FinRepFmv = new WinFormsField("FIN-REP-FMV", "FinRepFmv");
        public static WinFormsField SavingsCarrierInd = new WinFormsField("SAVINGS-CARRIER-IND", "SavingsCarrierInd");
        public static WinFormsField ReportUpdateMode = new WinFormsField("REPORT-UPDATE-MODE", "ReportUpdateMode");
        public static WinFormsField IndPayFrequency1 = new WinFormsField("IND-PAY-FREQUENCY-1", "IndPayFrequency1");
        public static WinFormsField EnabledDisabledInd = new WinFormsField("ENABLED-DISABLED-IND", "EnabledDisabledInd");
        public static WinFormsField IndAccumPeriodF1 = new WinFormsField("IND-ACCUM-PERIOD-F1", "IndAccumPeriodF1");
        public static WinFormsField Ehk01010PriceUpdatedInd = new WinFormsField("EHK01010-PRICE-UPDATED-IND", "Ehk01010PriceUpdatedInd");
        public static WinFormsField IndAccumPeriodT1 = new WinFormsField("IND-ACCUM-PERIOD-T1", "IndAccumPeriodT1");
        public static WinFormsField IndPayFrequency2 = new WinFormsField("IND-PAY-FREQUENCY-2", "IndPayFrequency2");
        public static WinFormsField IndAccumPeriodF2 = new WinFormsField("IND-ACCUM-PERIOD-F2", "IndAccumPeriodF2");
        public static WinFormsField IndAccumPeriodT2 = new WinFormsField("IND-ACCUM-PERIOD-T2", "IndAccumPeriodT2");
        public static WinFormsField IndPayFrequency3 = new WinFormsField("IND-PAY-FREQUENCY-3", "IndPayFrequency3");
        public static WinFormsField IndAccumPeriodF3 = new WinFormsField("IND-ACCUM-PERIOD-F3", "IndAccumPeriodF3");
        public static WinFormsField IndAccumPeriodT3 = new WinFormsField("IND-ACCUM-PERIOD-T3", "IndAccumPeriodT3");
        public static WinFormsField IndPayFrequency4 = new WinFormsField("IND-PAY-FREQUENCY-4", "IndPayFrequency4");
        public static WinFormsField IndAccumPeriodF4 = new WinFormsField("IND-ACCUM-PERIOD-F4", "IndAccumPeriodF4");
        public static WinFormsField IndAccumPeriodT4 = new WinFormsField("IND-ACCUM-PERIOD-T4", "IndAccumPeriodT4");
        public static WinFormsField DisplayONWebInd = new WinFormsField("DISPLAY-ON-WEB-IND", "DisplayONWebInd");
        public static WinFormsField CommentLine = new WinFormsField("COMMENT-LINE", "CommentLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgumentReg = new WinFormsField("LOCATE-ARGUMENT-REG", "LocateArgumentReg");
        public static WinFormsField LocateArgumentType = new WinFormsField("LOCATE-ARGUMENT-TYPE", "LocateArgumentType");
        public static WinFormsField LocateArgumentDate = new WinFormsField("LOCATE-ARGUMENT-DATE", "LocateArgumentDate");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
