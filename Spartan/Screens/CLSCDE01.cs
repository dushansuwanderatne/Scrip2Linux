using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLSCDE01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLSCDE01", "FormName");
		//Fields


        public static WinFormsField ClscdeKey0 = new WinFormsField("CLSCDE-KEY0", "ClscdeKey0");
        public static WinFormsField ClassGroupNumber = new WinFormsField("CLASS-GROUP-NUMBER", "ClassGroupNumber");
        public static WinFormsField SpecialNotifInd = new WinFormsField("SPECIAL-NOTIF-IND", "SpecialNotifInd");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField ConvertClassInd = new WinFormsField("CONVERT-CLASS-IND", "ConvertClassInd");
        public static WinFormsField ClassAuthorisedUnits = new WinFormsField("CLASS-AUTHORISED-UNITS", "ClassAuthorisedUnits");
        public static WinFormsField ClassStopTrade = new WinFormsField("CLASS-STOP-TRADE", "ClassStopTrade");
        public static WinFormsField ClassCloseDate = new WinFormsField("CLASS-CLOSE-DATE", "ClassCloseDate");
        public static WinFormsField ClassIssuedUnits = new WinFormsField("CLASS-ISSUED-UNITS", "ClassIssuedUnits");
        public static WinFormsField ClassTypeFlag = new WinFormsField("CLASS-TYPE-FLAG", "ClassTypeFlag");
        public static WinFormsField ScripIssueOption = new WinFormsField("SCRIP-ISSUE-OPTION", "ScripIssueOption");
        public static WinFormsField ClassParValue = new WinFormsField("CLASS-PAR-VALUE", "ClassParValue");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField ClassMoneyFlag = new WinFormsField("CLASS-MONEY-FLAG", "ClassMoneyFlag");
        public static WinFormsField LostScripRequired = new WinFormsField("LOST-SCRIP-REQUIRED", "LostScripRequired");
        public static WinFormsField FloatBrokerClassInd = new WinFormsField("FLOAT-BROKER-CLASS-IND", "FloatBrokerClassInd");
        public static WinFormsField ListedClassInd = new WinFormsField("LISTED-CLASS-IND", "ListedClassInd");
        public static WinFormsField LostScripComment = new WinFormsField("LOST-SCRIP-COMMENT", "LostScripComment");
        public static WinFormsField LostScripDatesTOPrint = new WinFormsField("LOST-SCRIP-DATES-TO-PRINT", "LostScripDatesTOPrint");
        public static WinFormsField SmvlstLevel = new WinFormsField("SMVLST-LEVEL", "SmvlstLevel");
        public static WinFormsField ClassScripFormat = new WinFormsField("CLASS-SCRIP-FORMAT", "ClassScripFormat");
        public static WinFormsField IntBearingClass = new WinFormsField("INT-BEARING-CLASS", "IntBearingClass");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField CommentLineStructure = new WinFormsField("COMMENT-LINE-STRUCTURE", "CommentLineStructure");
        public static WinFormsField IntPercentage = new WinFormsField("INT-PERCENTAGE", "IntPercentage");
        public static WinFormsField IntPeriod = new WinFormsField("INT-PERIOD", "IntPeriod");
        public static WinFormsField ClassTradeMinimum = new WinFormsField("CLASS-TRADE-MINIMUM", "ClassTradeMinimum");
        public static WinFormsField ClassScripComment = new WinFormsField("CLASS-SCRIP-COMMENT", "ClassScripComment");
        public static WinFormsField ClassTradeMaximum = new WinFormsField("CLASS-TRADE-MAXIMUM", "ClassTradeMaximum");
        public static WinFormsField ClassTradeMultiple = new WinFormsField("CLASS-TRADE-MULTIPLE", "ClassTradeMultiple");
        public static WinFormsField MarketableParcel = new WinFormsField("MARKETABLE-PARCEL", "MarketableParcel");
        public static WinFormsField ClassInvalidRegister = new WinFormsField("CLASS-INVALID-REGISTER", "ClassInvalidRegister");
        public static WinFormsField ClassTradeFrom = new WinFormsField("CLASS-TRADE-FROM", "ClassTradeFrom");
        public static WinFormsField PrincipalRegister = new WinFormsField("PRINCIPAL-REGISTER", "PrincipalRegister");
        public static WinFormsField BpayReference = new WinFormsField("BPAY-REFERENCE", "BpayReference");
        public static WinFormsField OptionIssueDate = new WinFormsField("OPTION-ISSUE-DATE", "OptionIssueDate");
        public static WinFormsField OptionExerciseDate = new WinFormsField("OPTION-EXERCISE-DATE", "OptionExerciseDate");
        public static WinFormsField EXPeriodSTDate = new WinFormsField("EX-PERIOD-ST-DATE", "EXPeriodSTDate");
        public static WinFormsField EXPeriodEndDate = new WinFormsField("EX-PERIOD-END-DATE", "EXPeriodEndDate");
        public static WinFormsField OptionLapseDate = new WinFormsField("OPTION-LAPSE-DATE", "OptionLapseDate");
        public static WinFormsField ExercisePrice = new WinFormsField("EXERCISE-PRICE", "ExercisePrice");
        public static WinFormsField NbrDecimals = new WinFormsField("NBR-DECIMALS", "NbrDecimals");
        public static WinFormsField Currency = new WinFormsField("CURRENCY", "Currency");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField ClsCharityInd = new WinFormsField("CLS-CHARITY-IND", "ClsCharityInd");
        public static WinFormsField AsxCode = new WinFormsField("ASX-CODE", "AsxCode");
        public static WinFormsField FirstActiveDate = new WinFormsField("FIRST-ACTIVE-DATE", "FirstActiveDate");
        public static WinFormsField CharityNOChangeDate = new WinFormsField("CHARITY-NO-CHANGE-DATE", "CharityNOChangeDate");
        public static WinFormsField NspEligibleInd = new WinFormsField("NSP-ELIGIBLE-IND", "NspEligibleInd");
        public static WinFormsField FirstListedDate = new WinFormsField("FIRST-LISTED-DATE", "FirstListedDate");
        public static WinFormsField SingleClassIcrInd = new WinFormsField("SINGLE-CLASS-ICR-IND", "SingleClassIcrInd");
        public static WinFormsField ReportableSubsysClsInd = new WinFormsField("REPORTABLE-SUBSYS-CLS-IND", "ReportableSubsysClsInd");
        public static WinFormsField LastListedDate = new WinFormsField("LAST-LISTED-DATE", "LastListedDate");
        public static WinFormsField SubsystemID = new WinFormsField("SUBSYSTEM-ID", "SubsystemID");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField AsxDescription = new WinFormsField("ASX-DESCRIPTION", "AsxDescription");
        public static WinFormsField FatcaObligationInd = new WinFormsField("FATCA-OBLIGATION-IND", "FatcaObligationInd");
        public static WinFormsField UnlistedEquityInd = new WinFormsField("UNLISTED-EQUITY-IND", "UnlistedEquityInd");
        public static WinFormsField EssDummyInd = new WinFormsField("ESS-DUMMY-IND", "EssDummyInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
