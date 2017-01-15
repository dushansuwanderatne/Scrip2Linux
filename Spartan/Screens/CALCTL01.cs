using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CALCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CALCTL01", "FormName");
		//Fields


        public static WinFormsField CalctlKey0 = new WinFormsField("CALCTL-KEY0", "CalctlKey0");
        public static WinFormsField CallClass = new WinFormsField("CALL-CLASS", "CallClass");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField ClassTO = new WinFormsField("CLASS-TO", "ClassTO");
        public static WinFormsField CurrentMoneyClass = new WinFormsField("CURRENT-MONEY-CLASS", "CurrentMoneyClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField UnallocatedHolder = new WinFormsField("UNALLOCATED-HOLDER", "UnallocatedHolder");
        public static WinFormsField ExceptNotingNbr = new WinFormsField("EXCEPT-NOTING-NBR", "ExceptNotingNbr");
        public static WinFormsField FirstNoticeDate = new WinFormsField("FIRST-NOTICE-DATE", "FirstNoticeDate");
        public static WinFormsField SecondNoticeDate = new WinFormsField("SECOND-NOTICE-DATE", "SecondNoticeDate");
        public static WinFormsField CallDueDate = new WinFormsField("CALL-DUE-DATE", "CallDueDate");
        public static WinFormsField AltMnyClass = new WinFormsField("ALT-MNY-CLASS", "AltMnyClass");
        public static WinFormsField DishonorClass = new WinFormsField("DISHONOR-CLASS", "DishonorClass");
        public static WinFormsField DishonorFlatFee = new WinFormsField("DISHONOR-FLAT-FEE", "DishonorFlatFee");
        public static WinFormsField Selreg = new WinFormsField("SELREG", "Selreg");
        public static WinFormsField PaidUPRate = new WinFormsField("PAID-UP-RATE", "PaidUPRate");
        public static WinFormsField ClassPaymentProcess = new WinFormsField("CLASS-PAYMENT-PROCESS", "ClassPaymentProcess");
        public static WinFormsField ToleranceLevelProcess = new WinFormsField("TOLERANCE-LEVEL-PROCESS", "ToleranceLevelProcess");
        public static WinFormsField ToleranceAmount = new WinFormsField("TOLERANCE-AMOUNT", "ToleranceAmount");
        public static WinFormsField TolerancePercentage = new WinFormsField("TOLERANCE-PERCENTAGE", "TolerancePercentage");
        public static WinFormsField SpecialCalc = new WinFormsField("SPECIAL-CALC", "SpecialCalc");
        public static WinFormsField PrintLabelUnits = new WinFormsField("PRINT-LABEL-UNITS", "PrintLabelUnits");
        public static WinFormsField BreakupCalc = new WinFormsField("BREAKUP-CALC", "BreakupCalc");
        public static WinFormsField CallPrice1 = new WinFormsField("CALL-PRICE1", "CallPrice1");
        public static WinFormsField Price1Desc = new WinFormsField("PRICE1-DESC", "Price1Desc");
        public static WinFormsField CallPrice2 = new WinFormsField("CALL-PRICE2", "CallPrice2");
        public static WinFormsField Price2Desc = new WinFormsField("PRICE2-DESC", "Price2Desc");
        public static WinFormsField CallStatus = new WinFormsField("CALL-STATUS", "CallStatus");
        public static WinFormsField NoticesRunNumber = new WinFormsField("NOTICES-RUN-NUMBER", "NoticesRunNumber");
        public static WinFormsField StartNoticeNumber = new WinFormsField("START-NOTICE-NUMBER", "StartNoticeNumber");
        public static WinFormsField NARunNumber = new WinFormsField("NA-RUN-NUMBER", "NARunNumber");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
