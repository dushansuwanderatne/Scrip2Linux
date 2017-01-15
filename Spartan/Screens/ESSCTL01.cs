using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSCTL01", "FormName");
		//Fields


        public static WinFormsField EssctlKey0 = new WinFormsField("ESSCTL-KEY0", "EssctlKey0");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField ReportUpdateMode = new WinFormsField("REPORT-UPDATE-MODE", "ReportUpdateMode");
        public static WinFormsField StartCrtTransNbr = new WinFormsField("START-CRT-TRANS-NBR", "StartCrtTransNbr");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField NameSelection = new WinFormsField("NAME-SELECTION", "NameSelection");
        public static WinFormsField EndCrtTransNbr = new WinFormsField("END-CRT-TRANS-NBR", "EndCrtTransNbr");
        public static WinFormsField AppropDate = new WinFormsField("APPROP-DATE", "AppropDate");
        public static WinFormsField PostcodeCheck = new WinFormsField("POSTCODE-CHECK", "PostcodeCheck");
        public static WinFormsField StartEssTransNbr = new WinFormsField("START-ESS-TRANS-NBR", "StartEssTransNbr");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField CheckUnits = new WinFormsField("CHECK-UNITS", "CheckUnits");
        public static WinFormsField EndEssTransNbr = new WinFormsField("END-ESS-TRANS-NBR", "EndEssTransNbr");
        public static WinFormsField UnitValue = new WinFormsField("UNIT-VALUE", "UnitValue");
        public static WinFormsField UpdateMandates = new WinFormsField("UPDATE-MANDATES", "UpdateMandates");
        public static WinFormsField LastRunNumber = new WinFormsField("LAST-RUN-NUMBER", "LastRunNumber");
        public static WinFormsField AwardExchangeRate = new WinFormsField("AWARD-EXCHANGE-RATE", "AwardExchangeRate");
        public static WinFormsField UpdateDrp = new WinFormsField("UPDATE-DRP", "UpdateDrp");
        public static WinFormsField EnabledDisabledInd = new WinFormsField("ENABLED-DISABLED-IND", "EnabledDisabledInd");
        public static WinFormsField PurchaseFree = new WinFormsField("PURCHASE-FREE", "PurchaseFree");
        public static WinFormsField InputRecCnt = new WinFormsField("INPUT-REC-CNT", "InputRecCnt");
        public static WinFormsField GrantDate = new WinFormsField("GRANT-DATE", "GrantDate");
        public static WinFormsField AddressMatching = new WinFormsField("ADDRESS-MATCHING", "AddressMatching");
        public static WinFormsField NewHolderCnt = new WinFormsField("NEW-HOLDER-CNT", "NewHolderCnt");
        public static WinFormsField DeductionType = new WinFormsField("DEDUCTION-TYPE", "DeductionType");
        public static WinFormsField AllowBlankAddress = new WinFormsField("ALLOW-BLANK-ADDRESS", "AllowBlankAddress");
        public static WinFormsField TransCnt = new WinFormsField("TRANS-CNT", "TransCnt");
        public static WinFormsField Mec0PriceUpdatedInd = new WinFormsField("MEC0-PRICE-UPDATED-IND", "Mec0PriceUpdatedInd");
        public static WinFormsField UpdateAddrDetails = new WinFormsField("UPDATE-ADDR-DETAILS", "UpdateAddrDetails");
        public static WinFormsField EmpDetailsCnt = new WinFormsField("EMP-DETAILS-CNT", "EmpDetailsCnt");
        public static WinFormsField DisplayONWebInd = new WinFormsField("DISPLAY-ON-WEB-IND", "DisplayONWebInd");
        public static WinFormsField UpdateEmpDetails = new WinFormsField("UPDATE-EMP-DETAILS", "UpdateEmpDetails");
        public static WinFormsField MandateCnt = new WinFormsField("MANDATE-CNT", "MandateCnt");
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField UpdateContactDetails = new WinFormsField("UPDATE-CONTACT-DETAILS", "UpdateContactDetails");
        public static WinFormsField DivReinvestCnt = new WinFormsField("DIV-REINVEST-CNT", "DivReinvestCnt");
        public static WinFormsField VestingStartDate = new WinFormsField("VESTING-START-DATE", "VestingStartDate");
        public static WinFormsField UploadTfn = new WinFormsField("UPLOAD-TFN", "UploadTfn");
        public static WinFormsField HldextRecCnt = new WinFormsField("HLDEXT-REC-CNT", "HldextRecCnt");
        public static WinFormsField IfrsFmv = new WinFormsField("IFRS-FMV", "IfrsFmv");
        public static WinFormsField RunTrnedt = new WinFormsField("RUN-TRNEDT", "RunTrnedt");
        public static WinFormsField ChgHolderCnt = new WinFormsField("CHG-HOLDER-CNT", "ChgHolderCnt");
        public static WinFormsField CreateNewAccount = new WinFormsField("CREATE-NEW-ACCOUNT", "CreateNewAccount");
        public static WinFormsField TfnTransCnt = new WinFormsField("TFN-TRANS-CNT", "TfnTransCnt");
        public static WinFormsField GrantAcceptanceInd = new WinFormsField("GRANT-ACCEPTANCE-IND", "GrantAcceptanceInd");
        public static WinFormsField Mec0AddrChangeORModify = new WinFormsField("MEC0-ADDR-CHANGE-OR-MODIFY", "Mec0AddrChangeORModify");
        public static WinFormsField ErrorCnt = new WinFormsField("ERROR-CNT", "ErrorCnt");
        public static WinFormsField AccBefTermEndInd = new WinFormsField("ACC-BEF-TERM-END-IND", "AccBefTermEndInd");
        public static WinFormsField Mec0FullTotalsInd = new WinFormsField("MEC0-FULL-TOTALS-IND", "Mec0FullTotalsInd");
        public static WinFormsField WarningCnt = new WinFormsField("WARNING-CNT", "WarningCnt");
        public static WinFormsField AccStartDate = new WinFormsField("ACC-START-DATE", "AccStartDate");
        public static WinFormsField AccEndDate = new WinFormsField("ACC-END-DATE", "AccEndDate");
        public static WinFormsField BankDetailsChgMod = new WinFormsField("BANK-DETAILS-CHG-MOD", "BankDetailsChgMod");
        public static WinFormsField DifferenceCnt = new WinFormsField("DIFFERENCE-CNT", "DifferenceCnt");
        public static WinFormsField DefaultElectInd = new WinFormsField("DEFAULT-ELECT-IND", "DefaultElectInd");
        public static WinFormsField AutoGenEmpUniqueID = new WinFormsField("AUTO-GEN-EMP-UNIQUE-ID", "AutoGenEmpUniqueID");
        public static WinFormsField InvalidCnt = new WinFormsField("INVALID-CNT", "InvalidCnt");
        public static WinFormsField ManualRevokeBulkID = new WinFormsField("MANUAL-REVOKE-BULK-ID", "ManualRevokeBulkID");
        public static WinFormsField ClearEmpUniqueID = new WinFormsField("CLEAR-EMP-UNIQUE-ID", "ClearEmpUniqueID");
        public static WinFormsField Mec0CommentLine = new WinFormsField("MEC0-COMMENT-LINE", "Mec0CommentLine");
        public static WinFormsField AutoRevokeBulkID = new WinFormsField("AUTO-REVOKE-BULK-ID", "AutoRevokeBulkID");
        public static WinFormsField AutoFtpHIReportsInd = new WinFormsField("AUTO-FTP-HI-REPORTS-IND", "AutoFtpHIReportsInd");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField PerformanceHurdlesInd = new WinFormsField("PERFORMANCE-HURDLES-IND", "PerformanceHurdlesInd");
        public static WinFormsField PerformanceCode = new WinFormsField("PERFORMANCE-CODE", "PerformanceCode");
        public static WinFormsField AccumPeriodFrom = new WinFormsField("ACCUM-PERIOD-FROM", "AccumPeriodFrom");
        public static WinFormsField AccumPeriodTO = new WinFormsField("ACCUM-PERIOD-TO", "AccumPeriodTO");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
