using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM01", "FormName");
		//Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField AHnaLine = new WinFormsField("A-HNA-LINE", "AHnaLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField APostcode = new WinFormsField("A-POSTCODE", "APostcode");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField AHldTypeCode = new WinFormsField("A-HLD-TYPE-CODE", "AHldTypeCode");
        public static WinFormsField HolderGroupCode = new WinFormsField("HOLDER-GROUP-CODE", "HolderGroupCode");
        public static WinFormsField AHldGroupCode = new WinFormsField("A-HLD-GROUP-CODE", "AHldGroupCode");
        public static WinFormsField HolderOtherTaxCode = new WinFormsField("HOLDER-OTHER-TAX-CODE", "HolderOtherTaxCode");
        public static WinFormsField AHldOtherTaxCode = new WinFormsField("A-HLD-OTHER-TAX-CODE", "AHldOtherTaxCode");
        public static WinFormsField ResidencyInd = new WinFormsField("RESIDENCY-IND", "ResidencyInd");
        public static WinFormsField AResidencyInd = new WinFormsField("A-RESIDENCY-IND", "AResidencyInd");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField ABrokerCode = new WinFormsField("A-BROKER-CODE", "ABrokerCode");
        public static WinFormsField FastRegister = new WinFormsField("FAST-REGISTER", "FastRegister");
        public static WinFormsField AFastRegister = new WinFormsField("A-FAST-REGISTER", "AFastRegister");
        public static WinFormsField ChessHolderStatus = new WinFormsField("CHESS-HOLDER-STATUS", "ChessHolderStatus");
        public static WinFormsField AChessHolderStatus = new WinFormsField("A-CHESS-HOLDER-STATUS", "AChessHolderStatus");
        public static WinFormsField HolderKeyModifier = new WinFormsField("HOLDER-KEY-MODIFIER", "HolderKeyModifier");
        public static WinFormsField AHolderKeyModifier = new WinFormsField("A-HOLDER-KEY-MODIFIER", "AHolderKeyModifier");
        public static WinFormsField UncertType = new WinFormsField("UNCERT-TYPE", "UncertType");
        public static WinFormsField AUncertType = new WinFormsField("A-UNCERT-TYPE", "AUncertType");
        public static WinFormsField HvfFlag = new WinFormsField("HVF-FLAG", "HvfFlag");
        public static WinFormsField AHvfFlag = new WinFormsField("A-HVF-FLAG", "AHvfFlag");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField AVariableField = new WinFormsField("A-VARIABLE-FIELD", "AVariableField");
        public static WinFormsField Abn = new WinFormsField("ABN", "Abn");
        public static WinFormsField AAbn = new WinFormsField("A-ABN", "AAbn");
        public static WinFormsField MailUnclaimedDate = new WinFormsField("MAIL-UNCLAIMED-DATE", "MailUnclaimedDate");
        public static WinFormsField AMailUnclaimedDate = new WinFormsField("A-MAIL-UNCLAIMED-DATE", "AMailUnclaimedDate");
        public static WinFormsField HolderAlternateID = new WinFormsField("HOLDER-ALTERNATE-ID", "HolderAlternateID");
        public static WinFormsField AHolderAlternateID = new WinFormsField("A-HOLDER-ALTERNATE-ID", "AHolderAlternateID");
        public static WinFormsField TaxFileNumberDesc = new WinFormsField("TAX-FILE-NUMBER-DESC", "TaxFileNumberDesc");
        public static WinFormsField ATfnDesc = new WinFormsField("A-TFN-DESC", "ATfnDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField BirthDate = new WinFormsField("BIRTH-DATE", "BirthDate");
        public static WinFormsField ABirthDate = new WinFormsField("A-BIRTH-DATE", "ABirthDate");
        public static WinFormsField HstDeceased = new WinFormsField("HST-DECEASED", "HstDeceased");
        public static WinFormsField HstException = new WinFormsField("HST-EXCEPTION", "HstException");
        public static WinFormsField HstSuppress = new WinFormsField("HST-SUPPRESS", "HstSuppress");
        public static WinFormsField HstStopTrade = new WinFormsField("HST-STOP-TRADE", "HstStopTrade");
        public static WinFormsField HstAnnualReport = new WinFormsField("HST-ANNUAL-REPORT", "HstAnnualReport");
        public static WinFormsField HstDivSournce = new WinFormsField("HST-DIV-SOURNCE", "HstDivSournce");
        public static WinFormsField AHstDeceased = new WinFormsField("A-HST-DECEASED", "AHstDeceased");
        public static WinFormsField AHstException = new WinFormsField("A-HST-EXCEPTION", "AHstException");
        public static WinFormsField AHstSuppress = new WinFormsField("A-HST-SUPPRESS", "AHstSuppress");
        public static WinFormsField AHstStopTrade = new WinFormsField("A-HST-STOP-TRADE", "AHstStopTrade");
        public static WinFormsField AHstAnnualReport = new WinFormsField("A-HST-ANNUAL-REPORT", "AHstAnnualReport");
        public static WinFormsField AHstDivSournce = new WinFormsField("A-HST-DIV-SOURNCE", "AHstDivSournce");
        public static WinFormsField ARNominated = new WinFormsField("AR-NOMINATED", "ARNominated");
        public static WinFormsField AARNominated = new WinFormsField("A-AR-NOMINATED", "AARNominated");
        public static WinFormsField AccessCode = new WinFormsField("ACCESS-CODE", "AccessCode");
        public static WinFormsField AAccessCode = new WinFormsField("A-ACCESS-CODE", "AAccessCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
