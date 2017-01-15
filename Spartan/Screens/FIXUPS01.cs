using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIXUPS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIXUPS01", "FormName");
		//Fields


        public static WinFormsField MenuItemMaladd = new WinFormsField("MENU-ITEM-MALADD", "MALADD. Mailing System Address File", "MailingSystemAddressFile");
        public static WinFormsField MenuItemPaytrn = new WinFormsField("MENU-ITEM-PAYTRN", "PAYTRN. Payment Transaction File", "PaymentTransactionFile");
        public static WinFormsField MenuItemSubanl = new WinFormsField("MENU-ITEM-SUBANL", "SUBANL. Subroutine Analysis File", "SubroutineAnalysisFile");
        public static WinFormsField MenuItemPlnctl0 = new WinFormsField("MENU-ITEM-PLNCTL0", "PLNCTL0. Plan Control (BSP/DRP)", "PlanControl(BSP/DRP)");
        public static WinFormsField MenuItemUsrsec = new WinFormsField("MENU-ITEM-USRSEC", "USRSEC. User Security File", "UserSecurityFile");
        public static WinFormsField MenuItemPlnctl1 = new WinFormsField("MENU-ITEM-PLNCTL1", "PLNCTL1. Plan Control (DIV)", "PlanControl(DIV)");
        public static WinFormsField MenuItemClient = new WinFormsField("MENU-ITEM-CLIENT", "CLIENT. Client file", "Clientfile");
        public static WinFormsField MenuItemBhplcr = new WinFormsField("MENU-ITEM-BHPLCR", "BHPLCR. BHP Loans Control File", "BHPLoansControlFile");
        public static WinFormsField MenuItemAsxths = new WinFormsField("MENU-ITEM-ASXTHS", "ASXTHS. ASX Trade History File", "ASXTradeHistoryFile");
        public static WinFormsField MenuItemBatreg = new WinFormsField("MENU-ITEM-BATREG", "BATREG. Float System Batch Register", "FloatSystemBatchRegister");
        public static WinFormsField MenuItemMsgdet = new WinFormsField("MENU-ITEM-MSGDET", "MSGDET. Message system - details file.", "Messagesystem-detailsfile.");
        public static WinFormsField MenuItemFltagt = new WinFormsField("MENU-ITEM-FLTAGT", "FLTAGT. Float Agent File", "FloatAgentFile");
        public static WinFormsField MenuItemMsgmul = new WinFormsField("MENU-ITEM-MSGMUL", "MSGMUL. Message User List File.", "MessageUserListFile.");
        public static WinFormsField MenuItemFltaap = new WinFormsField("MENU-ITEM-FLTAAP", "FLTAAP. Float Agent/Application File", "FloatAgent/ApplicationFile");
        public static WinFormsField MenuItemMsgusr = new WinFormsField("MENU-ITEM-MSGUSR", "MSGUSR. Message user file.", "Messageuserfile.");
        public static WinFormsField MenuItemFltpar = new WinFormsField("MENU-ITEM-FLTPAR", "FLTPAR. Float Parameter Details", "FloatParameterDetails");
        public static WinFormsField MenuItemMsgddf = new WinFormsField("MENU-ITEM-MSGDDF", "MSGDDF. Message Diary Detail File", "MessageDiaryDetailFile");
        public static WinFormsField MenuItemEisemp = new WinFormsField("MENU-ITEM-EISEMP", "EISEMP. EIS Employee Details File.", "EISEmployeeDetailsFile.");
        public static WinFormsField MenuItemDssaic = new WinFormsField("MENU-ITEM-DSSAIC", "DSSAIC. DSS Auto Indexing Control File", "DSSAutoIndexingControlFile");
        public static WinFormsField MenuItemTrncde = new WinFormsField("MENU-ITEM-TRNCDE", "TRNCDE. Transaction Type Code File ", "TransactionTypeCodeFile");
        public static WinFormsField MenuItemIcramt = new WinFormsField("MENU-ITEM-ICRAMT", "ICRAMT. Iss Cap Amounts", "IssCapAmounts");
        public static WinFormsField MenuItemIcrhst = new WinFormsField("MENU-ITEM-ICRHST", "ICRHST. Iss Cap History", "IssCapHistory");
        public static WinFormsField MenuItemIcrtrn = new WinFormsField("MENU-ITEM-ICRTRN", "ICRTRN. Iss Cap Tran Details", "IssCapTranDetails");
        public static WinFormsField MenuItemChsanl = new WinFormsField("MENU-ITEM-CHSANL", "CHSANL. Chess Analysis File", "ChessAnalysisFile");
        public static WinFormsField MenuItemChshis = new WinFormsField("MENU-ITEM-CHSHIS", "CHSHIS. Chess History File", "ChessHistoryFile");
        public static WinFormsField MenuItemChsunp = new WinFormsField("MENU-ITEM-CHSUNP", "CHSUNP. Chess Unapplied Trans file", "ChessUnappliedTransfile");
        public static WinFormsField MenuItemChsinp = new WinFormsField("MENU-ITEM-CHSINP", "CHSINP. Chess input bucket", "Chessinputbucket");
        public static WinFormsField MenuItemChsout = new WinFormsField("MENU-ITEM-CHSOUT", "CHSOUT. Chess output bucket", "Chessoutputbucket");
        public static WinFormsField MenuItemChsrej = new WinFormsField("MENU-ITEM-CHSREJ", "CHSREJ. CHESS Rejections", "CHESSRejections");
        public static WinFormsField MenuItemRepctl = new WinFormsField("MENU-ITEM-REPCTL", "REPCTL. Chess Reporting Request", "ChessReportingRequest");
        public static WinFormsField MenuItemHldcsdir = new WinFormsField("MENU-ITEM-HLDCSDIR", "HLDCSDIR. Irish Tax Common Details File", "IrishTaxCommonDetailsFile");
        public static WinFormsField MenuItemHldcsdza = new WinFormsField("MENU-ITEM-HLDCSDZA", "HLDCSDZA. South African Tax Common Details File", "SouthAfricanTaxCommonDetailsFile");
        public static WinFormsField MenuItemHldjsd01 = new WinFormsField("MENU-ITEM-HLDJSD01", "HLDJSD01. Irish Tax Joint Holder Tax Details", "IrishTaxJointHolderTaxDetails");
        public static WinFormsField MenuItemHldjsd02 = new WinFormsField("MENU-ITEM-HLDJSD02", "HLDJSD02. Irish Tax Joint Holder Beneficial Name/Address Details", "IrishTaxJointHolderBeneficialName/AddressDetails");
        public static WinFormsField MenuItemHldjsd03 = new WinFormsField("MENU-ITEM-HLDJSD03", "HLDJSD03. Irish Tax Joint Holder Last Tax Name/Address Details", "IrishTaxJointHolderLastTaxName/AddressDetails");
        public static WinFormsField MenuItemHldjsd04 = new WinFormsField("MENU-ITEM-HLDJSD04", "HLDJSD04. South African Tax Joint Holder Tax Details", "SouthAfricanTaxJointHolderTaxDetails");
        public static WinFormsField MenuItemHldjsd05 = new WinFormsField("MENU-ITEM-HLDJSD05", "HLDJSD05. South African Tax Email Address Details", "SouthAfricanTaxEmailAddressDetails");
        public static WinFormsField MenuItemHldjsd06 = new WinFormsField("MENU-ITEM-HLDJSD06", "HLDJSD06. South African Tax Beneficial Name/Address Details", "SouthAfricanTaxBeneficialName/AddressDetails");
        public static WinFormsField MenuItemHldjsd07 = new WinFormsField("MENU-ITEM-HLDJSD07", "HLDJSD07. South African Tax Postal Name/Address Details", "SouthAfricanTaxPostalName/AddressDetails");
        public static WinFormsField MenuItemTrndtl = new WinFormsField("MENU-ITEM-TRNDTL", "TRNDTL. Transaction Details ", "TransactionDetails");
        public static WinFormsField MenuItemScanal = new WinFormsField("MENU-ITEM-SCANAL", "SCANAL. Workflow (SCANALL)", "Workflow(SCANALL)");
        public static WinFormsField MenuItemBilctl = new WinFormsField("MENU-ITEM-BILCTL", "BILCTL. SLR Control File", "SLRControlFile");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit", "Exit");
        public static WinFormsField MenuItemNext = new WinFormsField("MENU-ITEM-NEXT", "NEXT. Next Screen of Files ", "NextScreenofFiles");
    }
}
