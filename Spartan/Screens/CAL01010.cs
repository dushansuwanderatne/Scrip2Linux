using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CAL01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CAL01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CallDescription = new WinFormsField("CALL-DESCRIPTION", "CallDescription");
        public static WinFormsField CallClass = new WinFormsField("CALL-CLASS", "CallClass");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField ClassTO = new WinFormsField("CLASS-TO", "ClassTO");
        public static WinFormsField CurrMoneyClass = new WinFormsField("CURR-MONEY-CLASS", "CurrMoneyClass");
        public static WinFormsField AltMnyClass = new WinFormsField("ALT-MNY-CLASS", "AltMnyClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField Reg1 = new WinFormsField("REG-1", "Reg1");
        public static WinFormsField Reg2 = new WinFormsField("REG-2", "Reg2");
        public static WinFormsField CallPrice1 = new WinFormsField("CALL-PRICE1", "CallPrice1");
        public static WinFormsField Price1Desc = new WinFormsField("PRICE1-DESC", "Price1Desc");
        public static WinFormsField CallPrice2 = new WinFormsField("CALL-PRICE2", "CallPrice2");
        public static WinFormsField Price2Desc = new WinFormsField("PRICE2-DESC", "Price2Desc");
        public static WinFormsField PaidUPRate = new WinFormsField("PAID-UP-RATE", "PaidUPRate");
        public static WinFormsField ToleranceProcess = new WinFormsField("TOLERANCE-PROCESS", "ToleranceProcess");
        public static WinFormsField ToleranceAmount = new WinFormsField("TOLERANCE-AMOUNT", "ToleranceAmount");
        public static WinFormsField TolerancePercentage = new WinFormsField("TOLERANCE-PERCENTAGE", "TolerancePercentage");
        public static WinFormsField SpecialCalc = new WinFormsField("SPECIAL-CALC", "SpecialCalc");
        public static WinFormsField BreakupCalc = new WinFormsField("BREAKUP-CALC", "BreakupCalc");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
