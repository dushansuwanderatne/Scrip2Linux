using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCCTL01", "FormName");
		//Fields


        public static WinFormsField AccctlKey0 = new WinFormsField("ACCCTL-KEY0", "AccctlKey0");
        public static WinFormsField CorpActionDesc = new WinFormsField("CORP-ACTION-DESC", "CorpActionDesc");
        public static WinFormsField ActiveDateFrom = new WinFormsField("ACTIVE-DATE-FROM", "ActiveDateFrom");
        public static WinFormsField EntitlementClass = new WinFormsField("ENTITLEMENT-CLASS", "EntitlementClass");
        public static WinFormsField LastActivityScanRun = new WinFormsField("LAST-ACTIVITY-SCAN-RUN", "LastActivityScanRun");
        public static WinFormsField ActiveDateTO = new WinFormsField("ACTIVE-DATE-TO", "ActiveDateTO");
        public static WinFormsField AcceptanceClass = new WinFormsField("ACCEPTANCE-CLASS", "AcceptanceClass");
        public static WinFormsField LastAPReconRun = new WinFormsField("LAST-AP-RECON-RUN", "LastAPReconRun");
        public static WinFormsField RemittanceEndDate = new WinFormsField("REMITTANCE-END-DATE", "RemittanceEndDate");
        public static WinFormsField OverrideUnitClass = new WinFormsField("OVERRIDE-UNIT-CLASS", "OverrideUnitClass");
        public static WinFormsField RecalcTranTypeCode = new WinFormsField("RECALC-TRAN-TYPE-CODE", "RecalcTranTypeCode");
        public static WinFormsField IntradayRunInd = new WinFormsField("INTRADAY-RUN-IND", "IntradayRunInd");
        public static WinFormsField ReceiptRoutingID = new WinFormsField("RECEIPT-ROUTING-ID", "ReceiptRoutingID");
        public static WinFormsField LastUrrRun = new WinFormsField("LAST-URR-RUN", "LastUrrRun");
        public static WinFormsField ProcessINUrrInd = new WinFormsField("PROCESS-IN-URR-IND", "ProcessINUrrInd");
        public static WinFormsField UserMsgid = new WinFormsField("USER-MSGID", "UserMsgid");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField ControlHolder = new WinFormsField("CONTROL-HOLDER", "ControlHolder");
        public static WinFormsField RecalcStatus = new WinFormsField("RECALC-STATUS", "RecalcStatus");
        public static WinFormsField APriceKnownInd = new WinFormsField("A-PRICE-KNOWN-IND", "APriceKnownInd");
        public static WinFormsField AAcceptanceMinimum = new WinFormsField("A-ACCEPTANCE-MINIMUM", "AAcceptanceMinimum");
        public static WinFormsField AAccLvlCalType = new WinFormsField("A-ACC-LVL-CAL-TYPE", "AAccLvlCalType");
        public static WinFormsField AUnitPrice = new WinFormsField("A-UNIT-PRICE", "AUnitPrice");
        public static WinFormsField AAcceptanceMultiple = new WinFormsField("A-ACCEPTANCE-MULTIPLE", "AAcceptanceMultiple");
        public static WinFormsField AToleranceAmount = new WinFormsField("A-TOLERANCE-AMOUNT", "AToleranceAmount");
        public static WinFormsField AAcceptanceMaximum = new WinFormsField("A-ACCEPTANCE-MAXIMUM", "AAcceptanceMaximum");
        public static WinFormsField AAcceptanceLvlMoney1 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-1", "AAcceptanceLvlMoney1");
        public static WinFormsField AAcceptanceLvlUnits1 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-1", "AAcceptanceLvlUnits1");
        public static WinFormsField ACostOFUnits1 = new WinFormsField("A-COST-OF-UNITS-1", "ACostOFUnits1");
        public static WinFormsField AAcceptanceLvlMoney10 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-10", "AAcceptanceLvlMoney10");
        public static WinFormsField AAcceptanceLvlUnits10 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-10", "AAcceptanceLvlUnits10");
        public static WinFormsField ACostOFUnits10 = new WinFormsField("A-COST-OF-UNITS-10", "ACostOFUnits10");
        public static WinFormsField AAcceptanceLvlMoney2 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-2", "AAcceptanceLvlMoney2");
        public static WinFormsField AAcceptanceLvlUnits2 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-2", "AAcceptanceLvlUnits2");
        public static WinFormsField ACostOFUnits2 = new WinFormsField("A-COST-OF-UNITS-2", "ACostOFUnits2");
        public static WinFormsField AAcceptanceLvlMoney11 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-11", "AAcceptanceLvlMoney11");
        public static WinFormsField AAcceptanceLvlUnits11 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-11", "AAcceptanceLvlUnits11");
        public static WinFormsField ACostOFUnits11 = new WinFormsField("A-COST-OF-UNITS-11", "ACostOFUnits11");
        public static WinFormsField AAcceptanceLvlMoney3 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-3", "AAcceptanceLvlMoney3");
        public static WinFormsField AAcceptanceLvlUnits3 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-3", "AAcceptanceLvlUnits3");
        public static WinFormsField ACostOFUnits3 = new WinFormsField("A-COST-OF-UNITS-3", "ACostOFUnits3");
        public static WinFormsField AAcceptanceLvlMoney12 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-12", "AAcceptanceLvlMoney12");
        public static WinFormsField AAcceptanceLvlUnits12 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-12", "AAcceptanceLvlUnits12");
        public static WinFormsField ACostOFUnits12 = new WinFormsField("A-COST-OF-UNITS-12", "ACostOFUnits12");
        public static WinFormsField AAcceptanceLvlMoney4 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-4", "AAcceptanceLvlMoney4");
        public static WinFormsField AAcceptanceLvlUnits4 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-4", "AAcceptanceLvlUnits4");
        public static WinFormsField ACostOFUnits4 = new WinFormsField("A-COST-OF-UNITS-4", "ACostOFUnits4");
        public static WinFormsField AAcceptanceLvlMoney13 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-13", "AAcceptanceLvlMoney13");
        public static WinFormsField AAcceptanceLvlUnits13 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-13", "AAcceptanceLvlUnits13");
        public static WinFormsField ACostOFUnits13 = new WinFormsField("A-COST-OF-UNITS-13", "ACostOFUnits13");
        public static WinFormsField AAcceptanceLvlMoney5 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-5", "AAcceptanceLvlMoney5");
        public static WinFormsField AAcceptanceLvlUnits5 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-5", "AAcceptanceLvlUnits5");
        public static WinFormsField ACostOFUnits5 = new WinFormsField("A-COST-OF-UNITS-5", "ACostOFUnits5");
        public static WinFormsField AAcceptanceLvlMoney14 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-14", "AAcceptanceLvlMoney14");
        public static WinFormsField AAcceptanceLvlUnits14 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-14", "AAcceptanceLvlUnits14");
        public static WinFormsField ACostOFUnits14 = new WinFormsField("A-COST-OF-UNITS-14", "ACostOFUnits14");
        public static WinFormsField AAcceptanceLvlMoney6 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-6", "AAcceptanceLvlMoney6");
        public static WinFormsField AAcceptanceLvlUnits6 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-6", "AAcceptanceLvlUnits6");
        public static WinFormsField ACostOFUnits6 = new WinFormsField("A-COST-OF-UNITS-6", "ACostOFUnits6");
        public static WinFormsField AAcceptanceLvlMoney15 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-15", "AAcceptanceLvlMoney15");
        public static WinFormsField AAcceptanceLvlUnits15 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-15", "AAcceptanceLvlUnits15");
        public static WinFormsField ACostOFUnits15 = new WinFormsField("A-COST-OF-UNITS-15", "ACostOFUnits15");
        public static WinFormsField AAcceptanceLvlMoney7 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-7", "AAcceptanceLvlMoney7");
        public static WinFormsField AAcceptanceLvlUnits7 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-7", "AAcceptanceLvlUnits7");
        public static WinFormsField ACostOFUnits7 = new WinFormsField("A-COST-OF-UNITS-7", "ACostOFUnits7");
        public static WinFormsField AAcceptanceLvlMoney16 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-16", "AAcceptanceLvlMoney16");
        public static WinFormsField AAcceptanceLvlUnits16 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-16", "AAcceptanceLvlUnits16");
        public static WinFormsField ACostOFUnits16 = new WinFormsField("A-COST-OF-UNITS-16", "ACostOFUnits16");
        public static WinFormsField AAcceptanceLvlMoney8 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-8", "AAcceptanceLvlMoney8");
        public static WinFormsField AAcceptanceLvlUnits8 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-8", "AAcceptanceLvlUnits8");
        public static WinFormsField ACostOFUnits8 = new WinFormsField("A-COST-OF-UNITS-8", "ACostOFUnits8");
        public static WinFormsField AAcceptanceLvlMoney17 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-17", "AAcceptanceLvlMoney17");
        public static WinFormsField AAcceptanceLvlUnits17 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-17", "AAcceptanceLvlUnits17");
        public static WinFormsField ACostOFUnits17 = new WinFormsField("A-COST-OF-UNITS-17", "ACostOFUnits17");
        public static WinFormsField AAcceptanceLvlMoney9 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-9", "AAcceptanceLvlMoney9");
        public static WinFormsField AAcceptanceLvlUnits9 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-9", "AAcceptanceLvlUnits9");
        public static WinFormsField ACostOFUnits9 = new WinFormsField("A-COST-OF-UNITS-9", "ACostOFUnits9");
        public static WinFormsField AAcceptanceLvlMoney18 = new WinFormsField("A-ACCEPTANCE-LVL-MONEY-18", "AAcceptanceLvlMoney18");
        public static WinFormsField AAcceptanceLvlUnits18 = new WinFormsField("A-ACCEPTANCE-LVL-UNITS-18", "AAcceptanceLvlUnits18");
        public static WinFormsField ACostOFUnits18 = new WinFormsField("A-COST-OF-UNITS-18", "ACostOFUnits18");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
