using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01503", "FormName");
		//Fields
        public static WinFormsField MultiSiteFlag = new WinFormsField("MULTI-SITE-FLAG", "MultiSiteFlag");
        public static WinFormsField ProcessCountry = new WinFormsField("PROCESS-COUNTRY", "ProcessCountry");
        public static WinFormsField PrincipalCountry = new WinFormsField("PRINCIPAL-COUNTRY", "PrincipalCountry");
        public static WinFormsField PrincipalRegister = new WinFormsField("PRINCIPAL-REGISTER", "PrincipalRegister");
        public static WinFormsField ProcessGroupCode = new WinFormsField("PROCESS-GROUP-CODE", "ProcessGroupCode");
        public static WinFormsField BillingCode = new WinFormsField("BILLING-CODE", "BillingCode");
        public static WinFormsField LastHolderCert = new WinFormsField("LAST-HOLDER-CERT", "LastHolderCert");
        public static WinFormsField LastHolderIssSP9 = new WinFormsField("LAST-HOLDER-ISS-SP-9", "LastHolderIssSP9");
        public static WinFormsField LastFasterNbr = new WinFormsField("LAST-FASTER-NBR", "LastFasterNbr");
        public static WinFormsField LastHldTransNbr = new WinFormsField("LAST-HLD-TRANS-NBR", "LastHldTransNbr");
        public static WinFormsField LastCrtTransNbr = new WinFormsField("LAST-CRT-TRANS-NBR", "LastCrtTransNbr");
        public static WinFormsField LastPayTransNbr = new WinFormsField("LAST-PAY-TRANS-NBR", "LastPayTransNbr");
        public static WinFormsField UseDpid = new WinFormsField("USE-DPID", "UseDpid");
        public static WinFormsField IcrEnabledInd = new WinFormsField("ICR-ENABLED-IND", "IcrEnabledInd");
        public static WinFormsField CustodianProcess = new WinFormsField("CUSTODIAN-PROCESS", "CustodianProcess");
        public static WinFormsField EssFinRptExp = new WinFormsField("ESS-FIN-RPT-EXP", "EssFinRptExp");
        public static WinFormsField AnnualFlag = new WinFormsField("ANNUAL-FLAG", "AnnualFlag");
        public static WinFormsField EssFullRptExpDT = new WinFormsField("ESS-FULL-RPT-EXP-DT", "EssFullRptExpDT");
        public static WinFormsField AnnualPostFlag = new WinFormsField("ANNUAL-POST-FLAG", "AnnualPostFlag");
        public static WinFormsField EssIncRptExpDT = new WinFormsField("ESS-INC-RPT-EXP-DT", "EssIncRptExpDT");
        public static WinFormsField Hks01503BillingService = new WinFormsField("HKS01503-BILLING-SERVICE", "Hks01503BillingService");
        public static WinFormsField EssFinEnableAuto = new WinFormsField("ESS-FIN-ENABLE-AUTO", "EssFinEnableAuto");
        public static WinFormsField CoyCharityInd = new WinFormsField("COY-CHARITY-IND", "CoyCharityInd");
        public static WinFormsField DrpCharitySource = new WinFormsField("DRP-CHARITY-SOURCE", "DrpCharitySource");
        public static WinFormsField CharitiesPerClass = new WinFormsField("CHARITIES-PER-CLASS", "CharitiesPerClass");
        public static WinFormsField CharityDollarsInd = new WinFormsField("CHARITY-DOLLARS-IND", "CharityDollarsInd");
        public static WinFormsField CharityPercentInd = new WinFormsField("CHARITY-PERCENT-IND", "CharityPercentInd");
        public static WinFormsField PICurrRstInd = new WinFormsField("PI-CURR-RST-IND", "PICurrRstInd");
        public static WinFormsField PICurrRstSTDate = new WinFormsField("PI-CURR-RST-ST-DATE", "PICurrRstSTDate");
        public static WinFormsField PICurrRstEndDate = new WinFormsField("PI-CURR-RST-END-DATE", "PICurrRstEndDate");
        public static WinFormsField PICurrRstOrideInd = new WinFormsField("PI-CURR-RST-ORIDE-IND", "PICurrRstOrideInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField UnclaimedReportInd = new WinFormsField("UNCLAIMED-REPORT-IND", "UnclaimedReportInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
