using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNTROL04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNTROL04", "FormName");
		//Fields


        public static WinFormsField CntrolKey0 = new WinFormsField("CNTROL-KEY0", "CntrolKey0");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField HldaddRecordCount = new WinFormsField("HLDADD-RECORD-COUNT", "HldaddRecordCount");
        public static WinFormsField CoyInfoChargeTrans = new WinFormsField("COY-INFO-CHARGE-TRANS", "CoyInfoChargeTrans");
        public static WinFormsField DailyReconciliationInd = new WinFormsField("DAILY-RECONCILIATION-IND", "DailyReconciliationInd");
        public static WinFormsField CoyInfoChargePymts = new WinFormsField("COY-INFO-CHARGE-PYMTS", "CoyInfoChargePymts");
        public static WinFormsField UrrAdviceFormat = new WinFormsField("URR-ADVICE-FORMAT", "UrrAdviceFormat");
        public static WinFormsField LostSrnNotOption = new WinFormsField("LOST-SRN-NOT-OPTION", "LostSrnNotOption");
        public static WinFormsField CoyInfoChargeValue = new WinFormsField("COY-INFO-CHARGE-VALUE", "CoyInfoChargeValue");
        public static WinFormsField NzlTaxDeducted = new WinFormsField("NZL-TAX-DEDUCTED", "NzlTaxDeducted");
        public static WinFormsField PreviousCdsexp = new WinFormsField("PREVIOUS-CDSEXP", "PreviousCdsexp");
        public static WinFormsField CoyInfoChargeCgt = new WinFormsField("COY-INFO-CHARGE-CGT", "CoyInfoChargeCgt");
        public static WinFormsField FasterScriplessNbr = new WinFormsField("FASTER-SCRIPLESS-NBR", "FasterScriplessNbr");
        public static WinFormsField BtrClientInd = new WinFormsField("BTR-CLIENT-IND", "BtrClientInd");
        public static WinFormsField ProcessAusInd = new WinFormsField("PROCESS-AUS-IND", "ProcessAusInd");
        public static WinFormsField LastFasterNbr = new WinFormsField("LAST-FASTER-NBR", "LastFasterNbr");
        public static WinFormsField ProcessNzlInd = new WinFormsField("PROCESS-NZL-IND", "ProcessNzlInd");
        public static WinFormsField FasterStatProg = new WinFormsField("FASTER-STAT-PROG", "FasterStatProg");
        public static WinFormsField CoyDCPrefAU = new WinFormsField("COY-DC-PREF-AU", "CoyDCPrefAU");
        public static WinFormsField ProcessGbrInd = new WinFormsField("PROCESS-GBR-IND", "ProcessGbrInd");
        public static WinFormsField LstsixmRun = new WinFormsField("LSTSIXM-RUN", "LstsixmRun");
        public static WinFormsField GedcrDataVersion = new WinFormsField("GEDCR-DATA-VERSION", "GedcrDataVersion");
        public static WinFormsField CoyDCPrefNZ = new WinFormsField("COY-DC-PREF-NZ", "CoyDCPrefNZ");
        public static WinFormsField ProcessIrlInd = new WinFormsField("PROCESS-IRL-IND", "ProcessIrlInd");
        public static WinFormsField LstweekRun = new WinFormsField("LSTWEEK-RUN", "LstweekRun");
        public static WinFormsField RedcaLastRun = new WinFormsField("REDCA-LAST-RUN", "RedcaLastRun");
        public static WinFormsField CoyDCPrefUK = new WinFormsField("COY-DC-PREF-UK", "CoyDCPrefUK");
        public static WinFormsField ProcessPngInd = new WinFormsField("PROCESS-PNG-IND", "ProcessPngInd");
        public static WinFormsField FinEnableAutoProcess = new WinFormsField("FIN-ENABLE-AUTO-PROCESS", "FinEnableAutoProcess");
        public static WinFormsField CoyDCPrefUS = new WinFormsField("COY-DC-PREF-US", "CoyDCPrefUS");
        public static WinFormsField BillingService = new WinFormsField("BILLING-SERVICE", "BillingService");
        public static WinFormsField MisStmUnitPriceFlg = new WinFormsField("MIS-STM-UNIT-PRICE-FLG", "MisStmUnitPriceFlg");
        public static WinFormsField ForeignRestrictnInd = new WinFormsField("FOREIGN-RESTRICTN-IND", "ForeignRestrictnInd");
        public static WinFormsField EssCompanyFlag = new WinFormsField("ESS-COMPANY-FLAG", "EssCompanyFlag");
        public static WinFormsField EssFinRptExp = new WinFormsField("ESS-FIN-RPT-EXP", "EssFinRptExp");
        public static WinFormsField SpecialOptScrnInd = new WinFormsField("SPECIAL-OPT-SCRN-IND", "SpecialOptScrnInd");
        public static WinFormsField LastUsanNbr = new WinFormsField("LAST-USAN-NBR", "LastUsanNbr");
        public static WinFormsField EssFullRptExpDate = new WinFormsField("ESS-FULL-RPT-EXP-DATE", "EssFullRptExpDate");
        public static WinFormsField TfeReason = new WinFormsField("TFE-REASON", "TfeReason");
        public static WinFormsField SignificantMoveInd = new WinFormsField("SIGNIFICANT-MOVE-IND", "SignificantMoveInd");
        public static WinFormsField EssIncRptExpDate = new WinFormsField("ESS-INC-RPT-EXP-DATE", "EssIncRptExpDate");
        public static WinFormsField CrestTfeRunFrom = new WinFormsField("CREST-TFE-RUN-FROM", "CrestTfeRunFrom");
        public static WinFormsField MovementLevel = new WinFormsField("MOVEMENT-LEVEL", "MovementLevel");
        public static WinFormsField DrpCharitySource = new WinFormsField("DRP-CHARITY-SOURCE", "DrpCharitySource");
        public static WinFormsField TrainsClass = new WinFormsField("TRAINS-CLASS", "TrainsClass");
        public static WinFormsField MovementSelection = new WinFormsField("MOVEMENT-SELECTION", "MovementSelection");
        public static WinFormsField USTaxReportingInd = new WinFormsField("US-TAX-REPORTING-IND", "USTaxReportingInd");
        public static WinFormsField UseDpidFlag = new WinFormsField("USE-DPID-FLAG", "UseDpidFlag");
        public static WinFormsField SignificantSeq = new WinFormsField("SIGNIFICANT-SEQ", "SignificantSeq");
        public static WinFormsField USTaxObligationCode = new WinFormsField("US-TAX-OBLIGATION-CODE", "USTaxObligationCode");
        public static WinFormsField CustodianProcessInd = new WinFormsField("CUSTODIAN-PROCESS-IND", "CustodianProcessInd");
        public static WinFormsField HinTOPrint = new WinFormsField("HIN-TO-PRINT", "HinTOPrint");
        public static WinFormsField USTaxGiin = new WinFormsField("US-TAX-GIIN", "USTaxGiin");
        public static WinFormsField AnnualReportFlag = new WinFormsField("ANNUAL-REPORT-FLAG", "AnnualReportFlag");
        public static WinFormsField LastUrrDate = new WinFormsField("LAST-URR-DATE", "LastUrrDate");
        public static WinFormsField CanTaxReportingInd = new WinFormsField("CAN-TAX-REPORTING-IND", "CanTaxReportingInd");
        public static WinFormsField DefaultPostalARFlag = new WinFormsField("DEFAULT-POSTAL-AR-FLAG", "DefaultPostalARFlag");
        public static WinFormsField LastUrrTime = new WinFormsField("LAST-URR-TIME", "LastUrrTime");
        public static WinFormsField IrlTaxReportingInd = new WinFormsField("IRL-TAX-REPORTING-IND", "IrlTaxReportingInd");
        public static WinFormsField UnclaimedReportingInd = new WinFormsField("UNCLAIMED-REPORTING-IND", "UnclaimedReportingInd");
        public static WinFormsField UmyEventIdentifier = new WinFormsField("UMY-EVENT-IDENTIFIER", "UmyEventIdentifier");
        public static WinFormsField ZafTaxReportingInd = new WinFormsField("ZAF-TAX-REPORTING-IND", "ZafTaxReportingInd");
        public static WinFormsField ManagedInvestTrustInd = new WinFormsField("MANAGED-INVEST-TRUST-IND", "ManagedInvestTrustInd");
        public static WinFormsField LastFinReportID = new WinFormsField("LAST-FIN-REPORT-ID", "LastFinReportID");
        public static WinFormsField ZafTaxReference = new WinFormsField("ZAF-TAX-REFERENCE", "ZafTaxReference");
        public static WinFormsField IntInvestorCoy = new WinFormsField("INT-INVESTOR-COY", "IntInvestorCoy");
        public static WinFormsField LastICReconDate = new WinFormsField("LAST-IC-RECON-DATE", "LastICReconDate");
        public static WinFormsField EmailRegNoticeInd = new WinFormsField("EMAIL-REG-NOTICE-IND", "EmailRegNoticeInd");
        public static WinFormsField IntEmployeeCoy = new WinFormsField("INT-EMPLOYEE-COY", "IntEmployeeCoy");
        public static WinFormsField IssuerOnlineCoy = new WinFormsField("ISSUER-ONLINE-COY", "IssuerOnlineCoy");
        public static WinFormsField PowerOFAttNoticeInd = new WinFormsField("POWER-OF-ATT-NOTICE-IND", "PowerOFAttNoticeInd");
        public static WinFormsField InternetCoyName = new WinFormsField("INTERNET-COY-NAME", "InternetCoyName");
        public static WinFormsField PICurrRestInd = new WinFormsField("PI-CURR-REST-IND", "PICurrRestInd");
        public static WinFormsField EmailFailAck = new WinFormsField("EMAIL-FAIL-ACK", "EmailFailAck");
        public static WinFormsField AtoReportingInd = new WinFormsField("ATO-REPORTING-IND", "AtoReportingInd");
        public static WinFormsField PICurrRestSTDate = new WinFormsField("PI-CURR-REST-ST-DATE", "PICurrRestSTDate");
        public static WinFormsField EmailFailCountX = new WinFormsField("EMAIL-FAIL-COUNT-X", "EmailFailCountX");
        public static WinFormsField SubstAcctPeriodInd = new WinFormsField("SUBST-ACCT-PERIOD-IND", "SubstAcctPeriodInd");
        public static WinFormsField PICurrRestEndDate = new WinFormsField("PI-CURR-REST-END-DATE", "PICurrRestEndDate");
        public static WinFormsField AccurateEnabledInd = new WinFormsField("ACCURATE-ENABLED-IND", "AccurateEnabledInd");
        public static WinFormsField SapEndDateDD = new WinFormsField("SAP-END-DATE-DD", "SapEndDateDD");
        public static WinFormsField SapEndDateMM = new WinFormsField("SAP-END-DATE-MM", "SapEndDateMM");
        public static WinFormsField PICurrRestOrideInd = new WinFormsField("PI-CURR-REST-ORIDE-IND", "PICurrRestOrideInd");
        public static WinFormsField DateLastCgt = new WinFormsField("DATE-LAST-CGT", "DateLastCgt");
        public static WinFormsField FinExportTimestamp = new WinFormsField("FIN-EXPORT-TIMESTAMP", "FinExportTimestamp");
        public static WinFormsField EmpCommMethodsInd = new WinFormsField("EMP-COMM-METHODS-IND", "EmpCommMethodsInd");
    }
}
