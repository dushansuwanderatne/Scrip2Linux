using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS24004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS24004", "FormName");
		//Fields


        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField BulkCalcProgram = new WinFormsField("BULK-CALC-PROGRAM", "BulkCalcProgram");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargeDesc = new WinFormsField("CHARGE-DESC", "ChargeDesc");
        public static WinFormsField ResidueLevelPaidOut = new WinFormsField("RESIDUE-LEVEL-PAID-OUT", "ResidueLevelPaidOut");
        public static WinFormsField BulkGrossRounding = new WinFormsField("BULK-GROSS-ROUNDING", "BulkGrossRounding");
        public static WinFormsField DcbTape = new WinFormsField("DCB-TAPE", "DcbTape");
        public static WinFormsField SaleNotification = new WinFormsField("SALE-NOTIFICATION", "SaleNotification");
        public static WinFormsField ApplyDivDirCredit = new WinFormsField("APPLY-DIV-DIR-CREDIT", "ApplyDivDirCredit");
        public static WinFormsField TapeFormat = new WinFormsField("TAPE-FORMAT", "TapeFormat");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField PymtCurrency = new WinFormsField("PYMT-CURRENCY", "PymtCurrency");
        public static WinFormsField BuildPaymentsInd = new WinFormsField("BUILD-PAYMENTS-IND", "BuildPaymentsInd");
        public static WinFormsField VariableComment = new WinFormsField("VARIABLE-COMMENT", "VariableComment");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
