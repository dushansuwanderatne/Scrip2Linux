using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIXUPS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIXUPS02", "FormName");
		//Fields


        public static WinFormsField MenuItemBlkctl = new WinFormsField("MENU-ITEM-BLKCTL", "BLKCTL. Bulk Control File", "BulkControlFile");
        public static WinFormsField MenuItemAmpref = new WinFormsField("MENU-ITEM-AMPREF", "AMPREF. AMP Cross Reference File", "AMPCrossReferenceFile");
        public static WinFormsField MenuItemBlkdet = new WinFormsField("MENU-ITEM-BLKDET", "BLKDET. Bulk Detail File", "BulkDetailFile");
        public static WinFormsField MenuItemAmpmen = new WinFormsField("MENU-ITEM-AMPMEN", "AMPMEN. AMP Member Entitlement File", "AMPMemberEntitlementFile");
        public static WinFormsField MenuItemDlgtrn = new WinFormsField("MENU-ITEM-DLGTRN", "DLGTRN. Dealing Transaction File", "DealingTransactionFile");
        public static WinFormsField MenuItemAmpsen = new WinFormsField("MENU-ITEM-AMPSEN", "AMPSEN. AMP Share Entitlement File", "AMPShareEntitlementFile");
        public static WinFormsField MenuItemDlghis = new WinFormsField("MENU-ITEM-DLGHIS", "DLGHIS. Dealing History File", "DealingHistoryFile");
        public static WinFormsField MenuItemRegcom = new WinFormsField("MENU-ITEM-REGCOM", "REGCOM. Registry Communication Methods", "RegistryCommunicationMethods");
        public static WinFormsField MenuItemCoycom = new WinFormsField("MENU-ITEM-COYCOM", "COYCOM. Issuer Communication Methods", "IssuerCommunicationMethods");
        public static WinFormsField MenuItemPayatd = new WinFormsField("MENU-ITEM-PAYATD", "PAYATD. Accurate Multiple Trace Acc", "AccurateMultipleTraceAcc");
        public static WinFormsField MenuItemPndcom = new WinFormsField("MENU-ITEM-PNDCOM", "PNDCOM. Pending Communications File", "PendingCommunicationsFile");
        public static WinFormsField MenuItemPayiat = new WinFormsField("MENU-ITEM-PAYIAT", "PAYIAT. IAT Compliance Reporting Data", "IATComplianceReportingData");
        public static WinFormsField MenuItemFwdins = new WinFormsField("MENU-ITEM-FWDINS", "FWDINS. Forwarding Instructions File", "ForwardingInstructionsFile");
        public static WinFormsField MenuItemEssapr = new WinFormsField("MENU-ITEM-ESSAPR", "ESSAPR. ESS Scheme/Appropriation File", "ESSScheme/AppropriationFile");
        public static WinFormsField MenuItemPrxctl0 = new WinFormsField("MENU-ITEM-PRXCTL0", "PRXCTL0. Proxy Control File (Header)", "ProxyControlFile(Header)");
        public static WinFormsField MenuItemEssbos = new WinFormsField("MENU-ITEM-ESSBOS", "ESSBOS. ESS Blackout Schedule File", "ESSBlackoutScheduleFile");
        public static WinFormsField MenuItemPrxctl1 = new WinFormsField("MENU-ITEM-PRXCTL1", "PRXCTL1. Proxy Control File (Detail)", "ProxyControlFile(Detail)");
        public static WinFormsField MenuItemEssctl = new WinFormsField("MENU-ITEM-ESSCTL", "ESSCTL. ESS Control File", "ESSControlFile");
        public static WinFormsField MenuItemEssded = new WinFormsField("MENU-ITEM-ESSDED", "ESSDED. ESS Deduction File", "ESSDeductionFile");
        public static WinFormsField MenuItemBnkitg = new WinFormsField("MENU-ITEM-BNKITG", "BNKITG. Bank Integrity File", "BankIntegrityFile");
        public static WinFormsField MenuItemEssevc = new WinFormsField("MENU-ITEM-ESSEVC", "ESSEVC. ESS Event Control", "ESSEventControl");
        public static WinFormsField MenuItemBnkrmt = new WinFormsField("MENU-ITEM-BNKRMT", "BNKRMT. Bank Receipt Routing File", "BankReceiptRoutingFile");
        public static WinFormsField MenuItemEssevp = new WinFormsField("MENU-ITEM-ESSEVP", "ESSEVP. ESS Participation File", "ESSParticipationFile");
        public static WinFormsField MenuItemEssevt = new WinFormsField("MENU-ITEM-ESSEVT", "ESSEVT. ESS Event Setup", "ESSEventSetup");
        public static WinFormsField MenuItemTrdctl = new WinFormsField("MENU-ITEM-TRDCTL", "TRDCTL. Trading Control File", "TradingControlFile");
        public static WinFormsField MenuItemEsshld = new WinFormsField("MENU-ITEM-ESSHLD", "ESSHLD. ESS Holding of class/registers", "ESSHoldingofclass/registers");
        public static WinFormsField MenuItemTrdord = new WinFormsField("MENU-ITEM-TRDORD", "TRDORD. Trading Order File", "TradingOrderFile");
        public static WinFormsField MenuItemEsshvp = new WinFormsField("MENU-ITEM-ESSHVP", "ESSHVP. ESS Holder Vesting Perf File", "ESSHolderVestingPerfFile");
        public static WinFormsField MenuItemTrdhis = new WinFormsField("MENU-ITEM-TRDHIS", "TRDHIS. Trading History File", "TradingHistoryFile");
        public static WinFormsField MenuItemEssldc = new WinFormsField("MENU-ITEM-ESSLDC", "ESSLDC. ESS Empl Leaver Desc File", "ESSEmplLeaverDescFile");
        public static WinFormsField MenuItemTrdtrn = new WinFormsField("MENU-ITEM-TRDTRN", "TRDTRN. Trading Transaction File", "TradingTransactionFile");
        public static WinFormsField MenuItemEsslvs = new WinFormsField("MENU-ITEM-ESSLVS", "ESSLVS. ESS Leaver Schedule File", "ESSLeaverScheduleFile");
        public static WinFormsField MenuItemCshtrn = new WinFormsField("MENU-ITEM-CSHTRN", "CSHTRN. Trading Cash Management Trans", "TradingCashManagementTrans");
        public static WinFormsField MenuItemEispid = new WinFormsField("MENU-ITEM-EISPID", "EISPID. EIS Payroll-Id Control File", "EISPayroll-IdControlFile");
        public static WinFormsField MenuItemEssref = new WinFormsField("MENU-ITEM-ESSREF", "ESSREF. ESS Reference File", "ESSReferenceFile");
        public static WinFormsField MenuItemAtodet0 = new WinFormsField("MENU-ITEM-ATODET0", "ATODET0. ATO Details File (AIIR)", "ATODetailsFile(AIIR)");
        public static WinFormsField MenuItemEsssch = new WinFormsField("MENU-ITEM-ESSSCH", "ESSSCH. ESS Scheme Control File", "ESSSchemeControlFile");
        public static WinFormsField MenuItemAtodet1 = new WinFormsField("MENU-ITEM-ATODET1", "ATODET1. ATO Details File (CGT)", "ATODetailsFile(CGT)");
        public static WinFormsField MenuItemEsssoc = new WinFormsField("MENU-ITEM-ESSSOC", "ESSSOC. ESS Blackout Restricted File", "ESSBlackoutRestrictedFile");
        public static WinFormsField MenuItemTxsctl = new WinFormsField("MENU-ITEM-TXSCTL", "TXSCTL. ESS Tax Statement Control File", "ESSTaxStatementControlFile");
        public static WinFormsField MenuItemEsstrn = new WinFormsField("MENU-ITEM-ESSTRN", "ESSTRN. ESS Money History Transactions", "ESSMoneyHistoryTransactions");
        public static WinFormsField MenuItemTxshis = new WinFormsField("MENU-ITEM-TXSHIS", "TXSHIS. ESS Tax Statement History File", "ESSTaxStatementHistoryFile");
        public static WinFormsField MenuItemEssvst = new WinFormsField("MENU-ITEM-ESSVST", "ESSVST. ESS Vesting Schedule File", "ESSVestingScheduleFile");
        public static WinFormsField MenuItemEsvwap = new WinFormsField("MENU-ITEM-ESVWAP", "ESVWAP. ESS SCRIP VWAP", "ESSSCRIPVWAP");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit", "Exit");
        public static WinFormsField MenuItemNext = new WinFormsField("MENU-ITEM-NEXT", "NEXT. Next Screen of Files ", "NextScreenofFiles");
    }
}
