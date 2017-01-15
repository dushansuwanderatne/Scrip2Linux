using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BLKCTL02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BLKCTL02", "FormName");
		//Fields


        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField BulkCalcProgram = new WinFormsField("BULK-CALC-PROGRAM", "BulkCalcProgram");
        public static WinFormsField ResidueLevelPaidOut = new WinFormsField("RESIDUE-LEVEL-PAID-OUT", "ResidueLevelPaidOut");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargeDesc = new WinFormsField("CHARGE-DESC", "ChargeDesc");
        public static WinFormsField BulkGrossRounding = new WinFormsField("BULK-GROSS-ROUNDING", "BulkGrossRounding");
        public static WinFormsField DcbTape = new WinFormsField("DCB-TAPE", "DcbTape");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField ApplyDivDirectCredit = new WinFormsField("APPLY-DIV-DIRECT-CREDIT", "ApplyDivDirectCredit");
        public static WinFormsField TapeFormat = new WinFormsField("TAPE-FORMAT", "TapeFormat");
        public static WinFormsField SettlementOrigin = new WinFormsField("SETTLEMENT-ORIGIN", "SettlementOrigin");
        public static WinFormsField BuildPaymentsInd = new WinFormsField("BUILD-PAYMENTS-IND", "BuildPaymentsInd");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField IncomeTaxDeductedInd = new WinFormsField("INCOME-TAX-DEDUCTED-IND", "IncomeTaxDeductedInd");
        public static WinFormsField DebitCreditFlag = new WinFormsField("DEBIT-CREDIT-FLAG", "DebitCreditFlag");
        public static WinFormsField IncomeTaxProgramName = new WinFormsField("INCOME-TAX-PROGRAM-NAME", "IncomeTaxProgramName");
        public static WinFormsField DirectCreditInstruction = new WinFormsField("DIRECT-CREDIT-INSTRUCTION", "DirectCreditInstruction");
        public static WinFormsField PymtCurrency = new WinFormsField("PYMT-CURRENCY", "PymtCurrency");
        public static WinFormsField VariableComment = new WinFormsField("VARIABLE-COMMENT", "VariableComment");
        public static WinFormsField TradeOrigin = new WinFormsField("TRADE-ORIGIN", "TradeOrigin");
    }
}
