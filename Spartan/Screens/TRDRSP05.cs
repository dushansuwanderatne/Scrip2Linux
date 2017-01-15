using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP05", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TrdCodeDesc = new WinFormsField("TRD-CODE-DESC", "TrdCodeDesc");
        public static WinFormsField TrdCodeCurrFlag = new WinFormsField("TRD-CODE-CURR-FLAG", "TrdCodeCurrFlag");
        public static WinFormsField TrdType = new WinFormsField("TRD-TYPE", "TrdType");
        public static WinFormsField RealTimeTrdInd = new WinFormsField("REAL-TIME-TRD-IND", "RealTimeTrdInd");
        public static WinFormsField TrdOrdStatus = new WinFormsField("TRD-ORD-STATUS", "TrdOrdStatus");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField CounterpartyDtl = new WinFormsField("COUNTERPARTY-DTL", "CounterpartyDtl");
        public static WinFormsField ContactDetails = new WinFormsField("CONTACT-DETAILS", "ContactDetails");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField DeletedDate = new WinFormsField("DELETED-DATE", "DeletedDate");
        public static WinFormsField CutOffDateTime = new WinFormsField("CUT-OFF-DATE-TIME", "CutOffDateTime");
        public static WinFormsField TrdDateTime = new WinFormsField("TRD-DATE-TIME", "TrdDateTime");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField ActSettledRun = new WinFormsField("ACT-SETTLED-RUN", "ActSettledRun");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField OrdDurationType = new WinFormsField("ORD-DURATION-TYPE", "OrdDurationType");
        public static WinFormsField OrdDuration = new WinFormsField("ORD-DURATION", "OrdDuration");
        public static WinFormsField OrmsOrdStatus = new WinFormsField("ORMS-ORD-STATUS", "OrmsOrdStatus");
        public static WinFormsField DateTimeOrdSent = new WinFormsField("DATE-TIME-ORD-SENT", "DateTimeOrdSent");
        public static WinFormsField LimitPrice = new WinFormsField("LIMIT-PRICE", "LimitPrice");
        public static WinFormsField AuditPrice = new WinFormsField("AUDIT-PRICE", "AuditPrice");
        public static WinFormsField PriceATAuditInd = new WinFormsField("PRICE-AT-AUDIT-IND", "PriceATAuditInd");
        public static WinFormsField TradePrice = new WinFormsField("TRADE-PRICE", "TradePrice");
        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerAcnt = new WinFormsField("BROKER-ACNT", "BrokerAcnt");
        public static WinFormsField ReconciliationCode = new WinFormsField("RECONCILIATION-CODE", "ReconciliationCode");
        public static WinFormsField CashTransRef = new WinFormsField("CASH-TRANS-REF", "CashTransRef");
        public static WinFormsField RptSpecIndEle1 = new WinFormsField("RPT-SPEC-IND-ELE-1", "RptSpecIndEle1");
        public static WinFormsField RptSpecIndEle2 = new WinFormsField("RPT-SPEC-IND-ELE-2", "RptSpecIndEle2");
        public static WinFormsField RptSpecIndEle3 = new WinFormsField("RPT-SPEC-IND-ELE-3", "RptSpecIndEle3");
        public static WinFormsField RptSpecIndEle4 = new WinFormsField("RPT-SPEC-IND-ELE-4", "RptSpecIndEle4");
        public static WinFormsField RptSpecIndEle5 = new WinFormsField("RPT-SPEC-IND-ELE-5", "RptSpecIndEle5");
        public static WinFormsField RptSpecIndEle6 = new WinFormsField("RPT-SPEC-IND-ELE-6", "RptSpecIndEle6");
        public static WinFormsField RptSpecIndEle7 = new WinFormsField("RPT-SPEC-IND-ELE-7", "RptSpecIndEle7");
        public static WinFormsField RptSpecIndEle8 = new WinFormsField("RPT-SPEC-IND-ELE-8", "RptSpecIndEle8");
        public static WinFormsField RptSpecIndEle9 = new WinFormsField("RPT-SPEC-IND-ELE-9", "RptSpecIndEle9");
        public static WinFormsField RptSpecIndEle10 = new WinFormsField("RPT-SPEC-IND-ELE-10", "RptSpecIndEle10");
        public static WinFormsField RptSpecIndEle11 = new WinFormsField("RPT-SPEC-IND-ELE-11", "RptSpecIndEle11");
        public static WinFormsField RptSpecIndEle12 = new WinFormsField("RPT-SPEC-IND-ELE-12", "RptSpecIndEle12");
        public static WinFormsField RptSpecIndEle13 = new WinFormsField("RPT-SPEC-IND-ELE-13", "RptSpecIndEle13");
        public static WinFormsField RptSpecIndEle14 = new WinFormsField("RPT-SPEC-IND-ELE-14", "RptSpecIndEle14");
        public static WinFormsField RptSpecIndEle15 = new WinFormsField("RPT-SPEC-IND-ELE-15", "RptSpecIndEle15");
        public static WinFormsField RptSpecTxtEle1 = new WinFormsField("RPT-SPEC-TXT-ELE-1", "RptSpecTxtEle1");
        public static WinFormsField RptSpecTxtEle2 = new WinFormsField("RPT-SPEC-TXT-ELE-2", "RptSpecTxtEle2");
        public static WinFormsField RptSpecTxtEle3 = new WinFormsField("RPT-SPEC-TXT-ELE-3", "RptSpecTxtEle3");
        public static WinFormsField RptSpecTxtEle4 = new WinFormsField("RPT-SPEC-TXT-ELE-4", "RptSpecTxtEle4");
        public static WinFormsField RptSpecTxtEle5 = new WinFormsField("RPT-SPEC-TXT-ELE-5", "RptSpecTxtEle5");
        public static WinFormsField RptSpecTxtEle6 = new WinFormsField("RPT-SPEC-TXT-ELE-6", "RptSpecTxtEle6");
        public static WinFormsField RptSpecTxtEle7 = new WinFormsField("RPT-SPEC-TXT-ELE-7", "RptSpecTxtEle7");
        public static WinFormsField RptSpecTxtEle8 = new WinFormsField("RPT-SPEC-TXT-ELE-8", "RptSpecTxtEle8");
        public static WinFormsField RptSpecTxtEle9 = new WinFormsField("RPT-SPEC-TXT-ELE-9", "RptSpecTxtEle9");
        public static WinFormsField RptSpecTxtEle10 = new WinFormsField("RPT-SPEC-TXT-ELE-10", "RptSpecTxtEle10");
        public static WinFormsField RptSpecTxtEle11 = new WinFormsField("RPT-SPEC-TXT-ELE-11", "RptSpecTxtEle11");
        public static WinFormsField RptSpecTxtEle12 = new WinFormsField("RPT-SPEC-TXT-ELE-12", "RptSpecTxtEle12");
        public static WinFormsField RptSpecTxtEle13 = new WinFormsField("RPT-SPEC-TXT-ELE-13", "RptSpecTxtEle13");
        public static WinFormsField RptSpecTxtEle14 = new WinFormsField("RPT-SPEC-TXT-ELE-14", "RptSpecTxtEle14");
        public static WinFormsField RptSpecTxtEle15 = new WinFormsField("RPT-SPEC-TXT-ELE-15", "RptSpecTxtEle15");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
