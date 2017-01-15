using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNTROL03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNTROL03", "FormName");
		//Fields


        public static WinFormsField CntrolKey0 = new WinFormsField("CNTROL-KEY0", "CntrolKey0");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField DefaultHolderCategory = new WinFormsField("DEFAULT-HOLDER-CATEGORY", "DefaultHolderCategory");
        public static WinFormsField ExtraEmpDetailsFlag = new WinFormsField("EXTRA-EMP-DETAILS-FLAG", "ExtraEmpDetailsFlag");
        public static WinFormsField HolderOriginA = new WinFormsField("HOLDER-ORIGIN-A", "HolderOriginA");
        public static WinFormsField OriginAStatus = new WinFormsField("ORIGIN-A-STATUS", "OriginAStatus");
        public static WinFormsField HolderOriginN = new WinFormsField("HOLDER-ORIGIN-N", "HolderOriginN");
        public static WinFormsField OriginNStatus = new WinFormsField("ORIGIN-N-STATUS", "OriginNStatus");
        public static WinFormsField CertificatedInd = new WinFormsField("CERTIFICATED-IND", "CertificatedInd");
        public static WinFormsField NbrDaysAdvanceLapse = new WinFormsField("NBR-DAYS-ADVANCE-LAPSE", "NbrDaysAdvanceLapse");
        public static WinFormsField HolderOriginB = new WinFormsField("HOLDER-ORIGIN-B", "HolderOriginB");
        public static WinFormsField OriginBStatus = new WinFormsField("ORIGIN-B-STATUS", "OriginBStatus");
        public static WinFormsField HolderOriginO = new WinFormsField("HOLDER-ORIGIN-O", "HolderOriginO");
        public static WinFormsField OriginOStatus = new WinFormsField("ORIGIN-O-STATUS", "OriginOStatus");
        public static WinFormsField UncertificatedInd = new WinFormsField("UNCERTIFICATED-IND", "UncertificatedInd");
        public static WinFormsField LapseLastRunDate = new WinFormsField("LAPSE-LAST-RUN-DATE", "LapseLastRunDate");
        public static WinFormsField HolderOriginC = new WinFormsField("HOLDER-ORIGIN-C", "HolderOriginC");
        public static WinFormsField OriginCStatus = new WinFormsField("ORIGIN-C-STATUS", "OriginCStatus");
        public static WinFormsField HolderOriginP = new WinFormsField("HOLDER-ORIGIN-P", "HolderOriginP");
        public static WinFormsField OriginPStatus = new WinFormsField("ORIGIN-P-STATUS", "OriginPStatus");
        public static WinFormsField CirclesIsin = new WinFormsField("CIRCLES-ISIN", "CirclesIsin");
        public static WinFormsField HolderOriginD = new WinFormsField("HOLDER-ORIGIN-D", "HolderOriginD");
        public static WinFormsField OriginDStatus = new WinFormsField("ORIGIN-D-STATUS", "OriginDStatus");
        public static WinFormsField HolderOriginQ = new WinFormsField("HOLDER-ORIGIN-Q", "HolderOriginQ");
        public static WinFormsField OriginQStatus = new WinFormsField("ORIGIN-Q-STATUS", "OriginQStatus");
        public static WinFormsField CirclesTimestamp = new WinFormsField("CIRCLES-TIMESTAMP", "CirclesTimestamp");
        public static WinFormsField HolderOriginE = new WinFormsField("HOLDER-ORIGIN-E", "HolderOriginE");
        public static WinFormsField OriginEStatus = new WinFormsField("ORIGIN-E-STATUS", "OriginEStatus");
        public static WinFormsField HolderOriginR = new WinFormsField("HOLDER-ORIGIN-R", "HolderOriginR");
        public static WinFormsField OriginRStatus = new WinFormsField("ORIGIN-R-STATUS", "OriginRStatus");
        public static WinFormsField CrestPendingCount = new WinFormsField("CREST-PENDING-COUNT", "CrestPendingCount");
        public static WinFormsField HolderOriginF = new WinFormsField("HOLDER-ORIGIN-F", "HolderOriginF");
        public static WinFormsField OriginFStatus = new WinFormsField("ORIGIN-F-STATUS", "OriginFStatus");
        public static WinFormsField HolderOriginS = new WinFormsField("HOLDER-ORIGIN-S", "HolderOriginS");
        public static WinFormsField OriginSStatus = new WinFormsField("ORIGIN-S-STATUS", "OriginSStatus");
        public static WinFormsField CrestHeldCount = new WinFormsField("CREST-HELD-COUNT", "CrestHeldCount");
        public static WinFormsField HolderOriginG = new WinFormsField("HOLDER-ORIGIN-G", "HolderOriginG");
        public static WinFormsField CrestCompanyStatus = new WinFormsField("CREST-COMPANY-STATUS", "CrestCompanyStatus");
        public static WinFormsField HolderOriginT = new WinFormsField("HOLDER-ORIGIN-T", "HolderOriginT");
        public static WinFormsField OriginTStatus = new WinFormsField("ORIGIN-T-STATUS", "OriginTStatus");
        public static WinFormsField UnlistedTrustType = new WinFormsField("UNLISTED-TRUST-TYPE", "UnlistedTrustType");
        public static WinFormsField TkoTransferFlag = new WinFormsField("TKO-TRANSFER-FLAG", "TkoTransferFlag");
        public static WinFormsField HolderOriginH = new WinFormsField("HOLDER-ORIGIN-H", "HolderOriginH");
        public static WinFormsField OriginHStatus = new WinFormsField("ORIGIN-H-STATUS", "OriginHStatus");
        public static WinFormsField HolderOriginU = new WinFormsField("HOLDER-ORIGIN-U", "HolderOriginU");
        public static WinFormsField OriginUStatus = new WinFormsField("ORIGIN-U-STATUS", "OriginUStatus");
        public static WinFormsField IncEntrepotAcc = new WinFormsField("INC-ENTREPOT-ACC", "IncEntrepotAcc");
        public static WinFormsField TkoTransferLastRun = new WinFormsField("TKO-TRANSFER-LAST-RUN", "TkoTransferLastRun");
        public static WinFormsField HolderOriginI = new WinFormsField("HOLDER-ORIGIN-I", "HolderOriginI");
        public static WinFormsField OriginIStatus = new WinFormsField("ORIGIN-I-STATUS", "OriginIStatus");
        public static WinFormsField HolderOriginV = new WinFormsField("HOLDER-ORIGIN-V", "HolderOriginV");
        public static WinFormsField OriginVStatus = new WinFormsField("ORIGIN-V-STATUS", "OriginVStatus");
        public static WinFormsField LikeHldrsIncChess = new WinFormsField("LIKE-HLDRS-INC-CHESS", "LikeHldrsIncChess");
        public static WinFormsField FirstTrustRun = new WinFormsField("FIRST-TRUST-RUN", "FirstTrustRun");
        public static WinFormsField HolderOriginJ = new WinFormsField("HOLDER-ORIGIN-J", "HolderOriginJ");
        public static WinFormsField OriginJStatus = new WinFormsField("ORIGIN-J-STATUS", "OriginJStatus");
        public static WinFormsField HolderOriginW = new WinFormsField("HOLDER-ORIGIN-W", "HolderOriginW");
        public static WinFormsField OriginWStatus = new WinFormsField("ORIGIN-W-STATUS", "OriginWStatus");
        public static WinFormsField WholeIrdNumber = new WinFormsField("WHOLE-IRD-NUMBER", "WholeIrdNumber");
        public static WinFormsField NewWholeIrdNumber = new WinFormsField("NEW-WHOLE-IRD-NUMBER", "NewWholeIrdNumber");
        public static WinFormsField HolderOriginK = new WinFormsField("HOLDER-ORIGIN-K", "HolderOriginK");
        public static WinFormsField OriginKStatus = new WinFormsField("ORIGIN-K-STATUS", "OriginKStatus");
        public static WinFormsField HolderOriginX = new WinFormsField("HOLDER-ORIGIN-X", "HolderOriginX");
        public static WinFormsField ChessStatusUnused = new WinFormsField("CHESS-STATUS-UNUSED", "ChessStatusUnused");
        public static WinFormsField IrdStreet = new WinFormsField("IRD-STREET", "IrdStreet");
        public static WinFormsField HolderOriginL = new WinFormsField("HOLDER-ORIGIN-L", "HolderOriginL");
        public static WinFormsField OriginLStatus = new WinFormsField("ORIGIN-L-STATUS", "OriginLStatus");
        public static WinFormsField HolderOriginY = new WinFormsField("HOLDER-ORIGIN-Y", "HolderOriginY");
        public static WinFormsField OriginYStatus = new WinFormsField("ORIGIN-Y-STATUS", "OriginYStatus");
        public static WinFormsField IrdSuburb = new WinFormsField("IRD-SUBURB", "IrdSuburb");
        public static WinFormsField HolderOriginM = new WinFormsField("HOLDER-ORIGIN-M", "HolderOriginM");
        public static WinFormsField OriginMStatus = new WinFormsField("ORIGIN-M-STATUS", "OriginMStatus");
        public static WinFormsField HolderOriginZ = new WinFormsField("HOLDER-ORIGIN-Z", "HolderOriginZ");
        public static WinFormsField OriginZStatus = new WinFormsField("ORIGIN-Z-STATUS", "OriginZStatus");
        public static WinFormsField PrintT200HldrNO = new WinFormsField("PRINT-T200-HLDR-NO", "PrintT200HldrNO");
        public static WinFormsField OfferorHin = new WinFormsField("OFFEROR-HIN", "OfferorHin");
        public static WinFormsField BhpPoolingAccount = new WinFormsField("BHP-POOLING-ACCOUNT", "BhpPoolingAccount");
        public static WinFormsField TrusteeAcn = new WinFormsField("TRUSTEE-ACN", "TrusteeAcn");
        public static WinFormsField AusBusinessNbr = new WinFormsField("AUS-BUSINESS-NBR", "AusBusinessNbr");
        public static WinFormsField AusBusinessNbrBranch = new WinFormsField("AUS-BUSINESS-NBR-BRANCH", "AusBusinessNbrBranch");
        public static WinFormsField EssDivisionFlag = new WinFormsField("ESS-DIVISION-FLAG", "EssDivisionFlag");
        public static WinFormsField EssSubDivisionFlag = new WinFormsField("ESS-SUB-DIVISION-FLAG", "EssSubDivisionFlag");
        public static WinFormsField EssPercentIssCapital = new WinFormsField("ESS-PERCENT-ISS-CAPITAL", "EssPercentIssCapital");
        public static WinFormsField CompanyClosedInd = new WinFormsField("COMPANY-CLOSED-IND", "CompanyClosedInd");
        public static WinFormsField AtoEftLargePayerCode = new WinFormsField("ATO-EFT-LARGE-PAYER-CODE", "AtoEftLargePayerCode");
    }
}
