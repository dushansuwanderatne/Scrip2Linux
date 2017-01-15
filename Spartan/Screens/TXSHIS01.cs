using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TXSHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TXSHIS01", "FormName");
		//Fields


        public static WinFormsField Mts0TxshisKey0 = new WinFormsField("MTS0-TXSHIS-KEY0", "Mts0TxshisKey0");
        public static WinFormsField Mts0EsstrnKey1 = new WinFormsField("MTS0-ESSTRN-KEY1", "Mts0EsstrnKey1");
        public static WinFormsField Mts0HolderIdentifier = new WinFormsField("MTS0-HOLDER-IDENTIFIER", "Mts0HolderIdentifier");
        public static WinFormsField Mts0ClassCode = new WinFormsField("MTS0-CLASS-CODE", "Mts0ClassCode");
        public static WinFormsField Mts0RegisterCode = new WinFormsField("MTS0-REGISTER-CODE", "Mts0RegisterCode");
        public static WinFormsField Mts0CertIdentifier = new WinFormsField("MTS0-CERT-IDENTIFIER", "Mts0CertIdentifier");
        public static WinFormsField Mts0TxsAmendmentIndicator = new WinFormsField("MTS0-TXS-AMENDMENT-INDICATOR", "Mts0TxsAmendmentIndicator");
        public static WinFormsField Mts0FinYear = new WinFormsField("MTS0-FIN-YEAR", "Mts0FinYear");
        public static WinFormsField TaxSeqNumber = new WinFormsField("TAX-SEQ-NUMBER", "TaxSeqNumber");
        public static WinFormsField Mts0TransactionType = new WinFormsField("MTS0-TRANSACTION-TYPE", "Mts0TransactionType");
        public static WinFormsField Mts0TaxEventDate = new WinFormsField("MTS0-TAX-EVENT-DATE", "Mts0TaxEventDate");
        public static WinFormsField Mts0TaxingPointCode = new WinFormsField("MTS0-TAXING-POINT-CODE", "Mts0TaxingPointCode");
        public static WinFormsField Mts0SubTransactionType = new WinFormsField("MTS0-SUB-TRANSACTION-TYPE", "Mts0SubTransactionType");
        public static WinFormsField Mts0TransCount = new WinFormsField("MTS0-TRANS-COUNT", "Mts0TransCount");
        public static WinFormsField Mts0RunNumber = new WinFormsField("MTS0-RUN-NUMBER", "Mts0RunNumber");
        public static WinFormsField Mts0TransNumber = new WinFormsField("MTS0-TRANS-NUMBER", "Mts0TransNumber");
        public static WinFormsField Mts0FromTOFlag = new WinFormsField("MTS0-FROM-TO-FLAG", "Mts0FromTOFlag");
        public static WinFormsField Mts0TransSequence = new WinFormsField("MTS0-TRANS-SEQUENCE", "Mts0TransSequence");
        public static WinFormsField Mts0TotalPurchaseCost = new WinFormsField("MTS0-TOTAL-PURCHASE-COST", "Mts0TotalPurchaseCost");
        public static WinFormsField Mts0TotalSharesPurchased = new WinFormsField("MTS0-TOTAL-SHARES-PURCHASED", "Mts0TotalSharesPurchased");
        public static WinFormsField Mts0TotalTfnAmt = new WinFormsField("MTS0-TOTAL-TFN-AMT", "Mts0TotalTfnAmt");
        public static WinFormsField Mts0TotalSharesWithdrawn = new WinFormsField("MTS0-TOTAL-SHARES-WITHDRAWN", "Mts0TotalSharesWithdrawn");
        public static WinFormsField Mts0PurchaseCost = new WinFormsField("MTS0-PURCHASE-COST", "Mts0PurchaseCost");
        public static WinFormsField Mts0WithdrawnDate = new WinFormsField("MTS0-WITHDRAWN-DATE", "Mts0WithdrawnDate");
        public static WinFormsField Mts0WithdrawalPrice = new WinFormsField("MTS0-WITHDRAWAL-PRICE", "Mts0WithdrawalPrice");
        public static WinFormsField CessationDate = new WinFormsField("CESSATION-DATE", "CessationDate");
        public static WinFormsField Mts0Proceeds = new WinFormsField("MTS0-PROCEEDS", "Mts0Proceeds");
        public static WinFormsField AssessableValueAvail = new WinFormsField("ASSESSABLE-VALUE-AVAIL", "AssessableValueAvail");
        public static WinFormsField Mts0AssessableIdxCapGain = new WinFormsField("MTS0-ASSESSABLE-IDX-CAP-GAIN", "Mts0AssessableIdxCapGain");
        public static WinFormsField Mts0CapitalGain = new WinFormsField("MTS0-CAPITAL-GAIN", "Mts0CapitalGain");
        public static WinFormsField Mts0Over30DaysProceeds = new WinFormsField("MTS0-OVER-30-DAYS-PROCEEDS", "Mts0Over30DaysProceeds");
        public static WinFormsField Mts0Less30DaysProceeds = new WinFormsField("MTS0-LESS-30-DAYS-PROCEEDS", "Mts0Less30DaysProceeds");
        public static WinFormsField Mts0TaxWithheld = new WinFormsField("MTS0-TAX-WITHHELD", "Mts0TaxWithheld");
        public static WinFormsField Mts0AssessableAmt = new WinFormsField("MTS0-ASSESSABLE-AMT", "Mts0AssessableAmt");
        public static WinFormsField CessationPriceFlag = new WinFormsField("CESSATION-PRICE-FLAG", "CessationPriceFlag");
        public static WinFormsField Mts0Over30DaySaleDate = new WinFormsField("MTS0-OVER-30-DAY-SALE-DATE", "Mts0Over30DaySaleDate");
        public static WinFormsField Mts0VwapTotalValue = new WinFormsField("MTS0-VWAP-TOTAL-VALUE", "Mts0VwapTotalValue");
        public static WinFormsField Mts0VwapGainLoss = new WinFormsField("MTS0-VWAP-GAIN-LOSS", "Mts0VwapGainLoss");
        public static WinFormsField Mts0VwapSaleProceeds = new WinFormsField("MTS0-VWAP-SALE-PROCEEDS", "Mts0VwapSaleProceeds");
        public static WinFormsField Mts0VwapCapitalGain = new WinFormsField("MTS0-VWAP-CAPITAL-GAIN", "Mts0VwapCapitalGain");
        public static WinFormsField Mts0LoanDeducted = new WinFormsField("MTS0-LOAN-DEDUCTED", "Mts0LoanDeducted");
        public static WinFormsField Mts0NetSaleProceeds = new WinFormsField("MTS0-NET-SALE-PROCEEDS", "Mts0NetSaleProceeds");
        public static WinFormsField Mts0TradeReference = new WinFormsField("MTS0-TRADE-REFERENCE", "Mts0TradeReference");
        public static WinFormsField Mts0IncidentalCosts = new WinFormsField("MTS0-INCIDENTAL-COSTS", "Mts0IncidentalCosts");
        public static WinFormsField ForeignNettAssessAmt = new WinFormsField("FOREIGN-NETT-ASSESS-AMT", "ForeignNettAssessAmt");
        public static WinFormsField CessationDateXRate = new WinFormsField("CESSATION-DATE-X-RATE", "CessationDateXRate");
        public static WinFormsField CessationPriceCurrency = new WinFormsField("CESSATION-PRICE-CURRENCY", "CessationPriceCurrency");
        public static WinFormsField Mts0AtoAmendmentIndicator = new WinFormsField("MTS0-ATO-AMENDMENT-INDICATOR", "Mts0AtoAmendmentIndicator");
        public static WinFormsField WorkStreamInd = new WinFormsField("WORK-STREAM-IND", "WorkStreamInd");
        public static WinFormsField TaxEventReversalInd = new WinFormsField("TAX-EVENT-REVERSAL-IND", "TaxEventReversalInd");
        public static WinFormsField Mts0AppropDate = new WinFormsField("MTS0-APPROP-DATE", "Mts0AppropDate");
        public static WinFormsField Mts0UnitValue = new WinFormsField("MTS0-UNIT-VALUE", "Mts0UnitValue");
        public static WinFormsField Mts0ResidualAmt = new WinFormsField("MTS0-RESIDUAL-AMT", "Mts0ResidualAmt");
        public static WinFormsField Mts0TfnAmtWithheld = new WinFormsField("MTS0-TFN-AMT-WITHHELD", "Mts0TfnAmtWithheld");
        public static WinFormsField Mts0TaxingPointDescription = new WinFormsField("MTS0-TAXING-POINT-DESCRIPTION", "Mts0TaxingPointDescription");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
