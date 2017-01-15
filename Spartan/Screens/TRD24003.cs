using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD24003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD24003", "FormName");
		//Fields
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradeType = new WinFormsField("TRADE-TYPE", "TradeType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField DispExecVenueInd = new WinFormsField("DISP-EXEC-VENUE-IND", "DispExecVenueInd");
        public static WinFormsField GenerateAdvices = new WinFormsField("GENERATE-ADVICES", "GenerateAdvices");
        public static WinFormsField AdviceProgram = new WinFormsField("ADVICE-PROGRAM", "AdviceProgram");
        public static WinFormsField GenerateCertificates = new WinFormsField("GENERATE-CERTIFICATES", "GenerateCertificates");
        public static WinFormsField SettlementProgram = new WinFormsField("SETTLEMENT-PROGRAM", "SettlementProgram");
        public static WinFormsField OnlineEntryInd = new WinFormsField("ONLINE-ENTRY-IND", "OnlineEntryInd");
        public static WinFormsField PhoneInterfaceInd = new WinFormsField("PHONE-INTERFACE-IND", "PhoneInterfaceInd");
        public static WinFormsField ExternalExercise = new WinFormsField("EXTERNAL-EXERCISE", "ExternalExercise");
        public static WinFormsField WebInterfaceInd = new WinFormsField("WEB-INTERFACE-IND", "WebInterfaceInd");
        public static WinFormsField CosmosConnectCode = new WinFormsField("COSMOS-CONNECT-CODE", "CosmosConnectCode");
        public static WinFormsField IvrInterfaceInd = new WinFormsField("IVR-INTERFACE-IND", "IvrInterfaceInd");
        public static WinFormsField SingleTradeInd = new WinFormsField("SINGLE-TRADE-IND", "SingleTradeInd");
        public static WinFormsField AuditInd = new WinFormsField("AUDIT-IND", "AuditInd");
        public static WinFormsField AuditSettlingTrans = new WinFormsField("AUDIT-SETTLING-TRANS", "AuditSettlingTrans");
        public static WinFormsField AllowCorporateBodies = new WinFormsField("ALLOW-CORPORATE-BODIES", "AllowCorporateBodies");
        public static WinFormsField AllowWarningFlag1 = new WinFormsField("ALLOW-WARNING-FLAG1", "AllowWarningFlag1");
        public static WinFormsField AllowPurchaseResidue = new WinFormsField("ALLOW-PURCHASE-RESIDUE", "AllowPurchaseResidue");
        public static WinFormsField AllowWarningFlag2 = new WinFormsField("ALLOW-WARNING-FLAG2", "AllowWarningFlag2");
        public static WinFormsField AllowReturnMail = new WinFormsField("ALLOW-RETURN-MAIL", "AllowReturnMail");
        public static WinFormsField AllowWarningFlag3 = new WinFormsField("ALLOW-WARNING-FLAG3", "AllowWarningFlag3");
        public static WinFormsField AllowDeceased = new WinFormsField("ALLOW-DECEASED", "AllowDeceased");
        public static WinFormsField AllowWarningFlag4 = new WinFormsField("ALLOW-WARNING-FLAG4", "AllowWarningFlag4");
        public static WinFormsField AllowPartialSell = new WinFormsField("ALLOW-PARTIAL-SELL", "AllowPartialSell");
        public static WinFormsField AllowWarningFlag5 = new WinFormsField("ALLOW-WARNING-FLAG5", "AllowWarningFlag5");
        public static WinFormsField AllowSellTOCover = new WinFormsField("ALLOW-SELL-TO-COVER", "AllowSellTOCover");
        public static WinFormsField Trd24003TaxResidualInd = new WinFormsField("TRD24003-TAX-RESIDUAL-IND", "Trd24003TaxResidualInd");
        public static WinFormsField AllowWarningFlag6 = new WinFormsField("ALLOW-WARNING-FLAG6", "AllowWarningFlag6");
        public static WinFormsField EstimateUnitsTopup = new WinFormsField("ESTIMATE-UNITS-TOPUP", "EstimateUnitsTopup");
        public static WinFormsField AllowWarningFlag7 = new WinFormsField("ALLOW-WARNING-FLAG7", "AllowWarningFlag7");
        public static WinFormsField AllowCertPartSell = new WinFormsField("ALLOW-CERT-PART-SELL", "AllowCertPartSell");
        public static WinFormsField AllowWarningFlag8 = new WinFormsField("ALLOW-WARNING-FLAG8", "AllowWarningFlag8");
        public static WinFormsField AllowSellSelected = new WinFormsField("ALLOW-SELL-SELECTED", "AllowSellSelected");
        public static WinFormsField AllowWarningFlag9 = new WinFormsField("ALLOW-WARNING-FLAG9", "AllowWarningFlag9");
        public static WinFormsField AllowFullSell = new WinFormsField("ALLOW-FULL-SELL", "AllowFullSell");
        public static WinFormsField AllowForeignResident = new WinFormsField("ALLOW-FOREIGN-RESIDENT", "AllowForeignResident");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField ForeignSelectInd = new WinFormsField("FOREIGN-SELECT-IND", "ForeignSelectInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField PartialText = new WinFormsField("PARTIAL-TEXT", "PartialText");
        public static WinFormsField PartialCertText = new WinFormsField("PARTIAL-CERT-TEXT", "PartialCertText");
        public static WinFormsField SelectedText = new WinFormsField("SELECTED-TEXT", "SelectedText");
        public static WinFormsField FullText = new WinFormsField("FULL-TEXT", "FullText");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
