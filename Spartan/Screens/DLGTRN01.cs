using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DLGTRN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DLGTRN01", "FormName");
		//Fields


        public static WinFormsField DlgtrnKey0 = new WinFormsField("DLGTRN-KEY0", "DlgtrnKey0");
        public static WinFormsField DealingTransStatus = new WinFormsField("DEALING-TRANS-STATUS", "DealingTransStatus");
        public static WinFormsField VersionNumber = new WinFormsField("VERSION-NUMBER", "VersionNumber");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField DealingID = new WinFormsField("DEALING-ID", "DealingID");
        public static WinFormsField CrtTransNumber = new WinFormsField("CRT-TRANS-NUMBER", "CrtTransNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField DlgTransNumber = new WinFormsField("DLG-TRANS-NUMBER", "DlgTransNumber");
        public static WinFormsField OriginalSessionNbr = new WinFormsField("ORIGINAL-SESSION-NBR", "OriginalSessionNbr");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField FromTOFlag = new WinFormsField("FROM-TO-FLAG", "FromTOFlag");
        public static WinFormsField OriginalStatus = new WinFormsField("ORIGINAL-STATUS", "OriginalStatus");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField TranSequence = new WinFormsField("TRAN-SEQUENCE", "TranSequence");
        public static WinFormsField AccumPeriod = new WinFormsField("ACCUM-PERIOD", "AccumPeriod");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField ReservationDate = new WinFormsField("RESERVATION-DATE", "ReservationDate");
        public static WinFormsField WithholdingTaxCode = new WinFormsField("WITHHOLDING-TAX-CODE", "WithholdingTaxCode");
        public static WinFormsField Money = new WinFormsField("MONEY", "Money");
        public static WinFormsField AuditFlag = new WinFormsField("AUDIT-FLAG", "AuditFlag");
        public static WinFormsField WithholdingTaxRate = new WinFormsField("WITHHOLDING-TAX-RATE", "WithholdingTaxRate");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
        public static WinFormsField DlgextInd = new WinFormsField("DLGEXT-IND", "DlgextInd");
        public static WinFormsField MarketValueType = new WinFormsField("MARKET-VALUE-TYPE", "MarketValueType");
        public static WinFormsField RemainingBalInd = new WinFormsField("REMAINING-BAL-IND", "RemainingBalInd");
        public static WinFormsField BulkDealInd = new WinFormsField("BULK-DEAL-IND", "BulkDealInd");
        public static WinFormsField MarketValueDate = new WinFormsField("MARKET-VALUE-DATE", "MarketValueDate");
        public static WinFormsField RemainingBal = new WinFormsField("REMAINING-BAL", "RemainingBal");
        public static WinFormsField SaleTypeInd = new WinFormsField("SALE-TYPE-IND", "SaleTypeInd");
        public static WinFormsField MarketValue = new WinFormsField("MARKET-VALUE", "MarketValue");
        public static WinFormsField NicAmount = new WinFormsField("NIC-AMOUNT", "NicAmount");
        public static WinFormsField IncludeResidueInd = new WinFormsField("INCLUDE-RESIDUE-IND", "IncludeResidueInd");
        public static WinFormsField AssessableUnits = new WinFormsField("ASSESSABLE-UNITS", "AssessableUnits");
        public static WinFormsField BsbCode = new WinFormsField("BSB-CODE", "BsbCode");
        public static WinFormsField BsbAccNumber = new WinFormsField("BSB-ACC-NUMBER", "BsbAccNumber");
        public static WinFormsField AssessableAmount = new WinFormsField("ASSESSABLE-AMOUNT", "AssessableAmount");
        public static WinFormsField AccountNameRollNbr = new WinFormsField("ACCOUNT-NAME-ROLL-NBR", "AccountNameRollNbr");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField TaxDeducted = new WinFormsField("TAX-DEDUCTED", "TaxDeducted");
        public static WinFormsField AvgTaxRate = new WinFormsField("AVG-TAX-RATE", "AvgTaxRate");
        public static WinFormsField Reason = new WinFormsField("REASON", "Reason");
        public static WinFormsField ResidualAmount = new WinFormsField("RESIDUAL-AMOUNT", "ResidualAmount");
        public static WinFormsField ExpiryDate = new WinFormsField("EXPIRY-DATE", "ExpiryDate");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField NomParticipant = new WinFormsField("NOM-PARTICIPANT", "NomParticipant");
        public static WinFormsField RetentionPeriodMonths = new WinFormsField("RETENTION-PERIOD-MONTHS", "RetentionPeriodMonths");
        public static WinFormsField RetentionPeriodDays = new WinFormsField("RETENTION-PERIOD-DAYS", "RetentionPeriodDays");
        public static WinFormsField BrokerReference = new WinFormsField("BROKER-REFERENCE", "BrokerReference");
        public static WinFormsField TaxRetentionPerMths = new WinFormsField("TAX-RETENTION-PER-MTHS", "TaxRetentionPerMths");
        public static WinFormsField TaxRetentionPerDays = new WinFormsField("TAX-RETENTION-PER-DAYS", "TaxRetentionPerDays");
        public static WinFormsField CancelReference = new WinFormsField("CANCEL-REFERENCE", "CancelReference");
        public static WinFormsField TaxMarketValue = new WinFormsField("TAX-MARKET-VALUE", "TaxMarketValue");
        public static WinFormsField ApplyDivInstruction = new WinFormsField("APPLY-DIV-INSTRUCTION", "ApplyDivInstruction");
        public static WinFormsField ReservationDeal = new WinFormsField("RESERVATION-DEAL", "ReservationDeal");
        public static WinFormsField RolledOverResidueInd = new WinFormsField("ROLLED-OVER-RESIDUE-IND", "RolledOverResidueInd");
        public static WinFormsField CountryNationality = new WinFormsField("COUNTRY-NATIONALITY", "CountryNationality");
        public static WinFormsField FreeFormatNote = new WinFormsField("FREE-FORMAT-NOTE", "FreeFormatNote");
        public static WinFormsField CountryJurisdOverride = new WinFormsField("COUNTRY-JURISD-OVERRIDE", "CountryJurisdOverride");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
