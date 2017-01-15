using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01501", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ChessUic = new WinFormsField("CHESS-UIC", "ChessUic");
        public static WinFormsField HolderOriginA = new WinFormsField("HOLDER-ORIGIN-A", "HolderOriginA");
        public static WinFormsField OriginAStatus = new WinFormsField("ORIGIN-A-STATUS", "OriginAStatus");
        public static WinFormsField FasterScripless = new WinFormsField("FASTER-SCRIPLESS", "FasterScripless");
        public static WinFormsField OriginNStatus = new WinFormsField("ORIGIN-N-STATUS", "OriginNStatus");
        public static WinFormsField SinNumber = new WinFormsField("SIN-NUMBER", "SinNumber");
        public static WinFormsField HolderOriginB = new WinFormsField("HOLDER-ORIGIN-B", "HolderOriginB");
        public static WinFormsField OriginBStatus = new WinFormsField("ORIGIN-B-STATUS", "OriginBStatus");
        public static WinFormsField HolderOriginO = new WinFormsField("HOLDER-ORIGIN-O", "HolderOriginO");
        public static WinFormsField OriginOStatus = new WinFormsField("ORIGIN-O-STATUS", "OriginOStatus");
        public static WinFormsField FasterScriplessNbr = new WinFormsField("FASTER-SCRIPLESS-NBR", "FasterScriplessNbr");
        public static WinFormsField CertCompany = new WinFormsField("CERT-COMPANY", "CertCompany");
        public static WinFormsField OriginCStatus = new WinFormsField("ORIGIN-C-STATUS", "OriginCStatus");
        public static WinFormsField HolderOriginP = new WinFormsField("HOLDER-ORIGIN-P", "HolderOriginP");
        public static WinFormsField OriginPStatus = new WinFormsField("ORIGIN-P-STATUS", "OriginPStatus");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField HolderOriginD = new WinFormsField("HOLDER-ORIGIN-D", "HolderOriginD");
        public static WinFormsField OriginDStatus = new WinFormsField("ORIGIN-D-STATUS", "OriginDStatus");
        public static WinFormsField HolderOriginQ = new WinFormsField("HOLDER-ORIGIN-Q", "HolderOriginQ");
        public static WinFormsField OriginQStatus = new WinFormsField("ORIGIN-Q-STATUS", "OriginQStatus");
        public static WinFormsField ExtraEmpDetailsFlag = new WinFormsField("EXTRA-EMP-DETAILS-FLAG", "ExtraEmpDetailsFlag");
        public static WinFormsField HolderOriginE = new WinFormsField("HOLDER-ORIGIN-E", "HolderOriginE");
        public static WinFormsField OriginEStatus = new WinFormsField("ORIGIN-E-STATUS", "OriginEStatus");
        public static WinFormsField HolderOriginR = new WinFormsField("HOLDER-ORIGIN-R", "HolderOriginR");
        public static WinFormsField OriginRStatus = new WinFormsField("ORIGIN-R-STATUS", "OriginRStatus");
        public static WinFormsField UnlistedTrustType = new WinFormsField("UNLISTED-TRUST-TYPE", "UnlistedTrustType");
        public static WinFormsField FastCompany = new WinFormsField("FAST-COMPANY", "FastCompany");
        public static WinFormsField OriginFStatus = new WinFormsField("ORIGIN-F-STATUS", "OriginFStatus");
        public static WinFormsField HolderOriginS = new WinFormsField("HOLDER-ORIGIN-S", "HolderOriginS");
        public static WinFormsField OriginSStatus = new WinFormsField("ORIGIN-S-STATUS", "OriginSStatus");
        public static WinFormsField MultiSiteFlag = new WinFormsField("MULTI-SITE-FLAG", "MultiSiteFlag");
        public static WinFormsField CrestCompany = new WinFormsField("CREST-COMPANY", "CrestCompany");
        public static WinFormsField OriginGStatus = new WinFormsField("ORIGIN-G-STATUS", "OriginGStatus");
        public static WinFormsField HolderOriginT = new WinFormsField("HOLDER-ORIGIN-T", "HolderOriginT");
        public static WinFormsField OriginTStatus = new WinFormsField("ORIGIN-T-STATUS", "OriginTStatus");
        public static WinFormsField ProcessAusInd = new WinFormsField("PROCESS-AUS-IND", "ProcessAusInd");
        public static WinFormsField ProcessIrlInd = new WinFormsField("PROCESS-IRL-IND", "ProcessIrlInd");
        public static WinFormsField HolderOriginH = new WinFormsField("HOLDER-ORIGIN-H", "HolderOriginH");
        public static WinFormsField OriginHStatus = new WinFormsField("ORIGIN-H-STATUS", "OriginHStatus");
        public static WinFormsField HolderOriginU = new WinFormsField("HOLDER-ORIGIN-U", "HolderOriginU");
        public static WinFormsField OriginUStatus = new WinFormsField("ORIGIN-U-STATUS", "OriginUStatus");
        public static WinFormsField ProcessGbrInd = new WinFormsField("PROCESS-GBR-IND", "ProcessGbrInd");
        public static WinFormsField ProcessNzlInd = new WinFormsField("PROCESS-NZL-IND", "ProcessNzlInd");
        public static WinFormsField IssSponsCompany = new WinFormsField("ISS-SPONS-COMPANY", "IssSponsCompany");
        public static WinFormsField OriginIStatus = new WinFormsField("ORIGIN-I-STATUS", "OriginIStatus");
        public static WinFormsField HolderOriginV = new WinFormsField("HOLDER-ORIGIN-V", "HolderOriginV");
        public static WinFormsField OriginVStatus = new WinFormsField("ORIGIN-V-STATUS", "OriginVStatus");
        public static WinFormsField ProcessPngInd = new WinFormsField("PROCESS-PNG-IND", "ProcessPngInd");
        public static WinFormsField HolderOriginJ = new WinFormsField("HOLDER-ORIGIN-J", "HolderOriginJ");
        public static WinFormsField OriginJStatus = new WinFormsField("ORIGIN-J-STATUS", "OriginJStatus");
        public static WinFormsField HolderOriginW = new WinFormsField("HOLDER-ORIGIN-W", "HolderOriginW");
        public static WinFormsField OriginWStatus = new WinFormsField("ORIGIN-W-STATUS", "OriginWStatus");
        public static WinFormsField PrincipalCountry = new WinFormsField("PRINCIPAL-COUNTRY", "PrincipalCountry");
        public static WinFormsField HolderOriginK = new WinFormsField("HOLDER-ORIGIN-K", "HolderOriginK");
        public static WinFormsField OriginKStatus = new WinFormsField("ORIGIN-K-STATUS", "OriginKStatus");
        public static WinFormsField ChessCompany = new WinFormsField("CHESS-COMPANY", "ChessCompany");
        public static WinFormsField OriginXStatus = new WinFormsField("ORIGIN-X-STATUS", "OriginXStatus");
        public static WinFormsField SpecialOptScrnInd = new WinFormsField("SPECIAL-OPT-SCRN-IND", "SpecialOptScrnInd");
        public static WinFormsField HolderOriginL = new WinFormsField("HOLDER-ORIGIN-L", "HolderOriginL");
        public static WinFormsField OriginLStatus = new WinFormsField("ORIGIN-L-STATUS", "OriginLStatus");
        public static WinFormsField HolderOriginY = new WinFormsField("HOLDER-ORIGIN-Y", "HolderOriginY");
        public static WinFormsField OriginYStatus = new WinFormsField("ORIGIN-Y-STATUS", "OriginYStatus");
        public static WinFormsField ForeignRestrictnInd = new WinFormsField("FOREIGN-RESTRICTN-IND", "ForeignRestrictnInd");
        public static WinFormsField HolderOriginM = new WinFormsField("HOLDER-ORIGIN-M", "HolderOriginM");
        public static WinFormsField OriginMStatus = new WinFormsField("ORIGIN-M-STATUS", "OriginMStatus");
        public static WinFormsField FasterCompany = new WinFormsField("FASTER-COMPANY", "FasterCompany");
        public static WinFormsField OriginZStatus = new WinFormsField("ORIGIN-Z-STATUS", "OriginZStatus");
        public static WinFormsField FinGenerated = new WinFormsField("FIN-GENERATED", "FinGenerated");
        public static WinFormsField EssCompanyFlag = new WinFormsField("ESS-COMPANY-FLAG", "EssCompanyFlag");
        public static WinFormsField Division = new WinFormsField("DIVISION", "Division");
        public static WinFormsField LastHldTransNbr = new WinFormsField("LAST-HLD-TRANS-NBR", "LastHldTransNbr");
        public static WinFormsField SubDivision = new WinFormsField("SUB-DIVISION", "SubDivision");
        public static WinFormsField LastCrtTransNbr = new WinFormsField("LAST-CRT-TRANS-NBR", "LastCrtTransNbr");
        public static WinFormsField PercentageIssCapital = new WinFormsField("PERCENTAGE-ISS-CAPITAL", "PercentageIssCapital");
        public static WinFormsField LastPayTransNbr = new WinFormsField("LAST-PAY-TRANS-NBR", "LastPayTransNbr");
        public static WinFormsField BtrClientInd = new WinFormsField("BTR-CLIENT-IND", "BtrClientInd");
        public static WinFormsField UseDpidFlag = new WinFormsField("USE-DPID-FLAG", "UseDpidFlag");
        public static WinFormsField JobSchedulerInd = new WinFormsField("JOB-SCHEDULER-IND", "JobSchedulerInd");
        public static WinFormsField Hks01501BillingService = new WinFormsField("HKS01501-BILLING-SERVICE", "Hks01501BillingService");
        public static WinFormsField NspForRetradesInd = new WinFormsField("NSP-FOR-RETRADES-IND", "NspForRetradesInd");
        public static WinFormsField ReactivatedTolerance = new WinFormsField("REACTIVATED-TOLERANCE", "ReactivatedTolerance");
        public static WinFormsField DateLastCgt = new WinFormsField("DATE-LAST-CGT", "DateLastCgt");
        public static WinFormsField UfdDeleteFlag = new WinFormsField("UFD-DELETE-FLAG", "UfdDeleteFlag");
        public static WinFormsField EmpCommMethods = new WinFormsField("EMP-COMM-METHODS", "EmpCommMethods");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree2 = new WinFormsField("SYSTEM-INFO-FREE-2", "16", "16");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
