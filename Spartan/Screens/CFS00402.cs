using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00402", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyUfdsel = new WinFormsField("COMPANY-UFDSEL", "CompanyUfdsel");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField HolderOriginA = new WinFormsField("HOLDER-ORIGIN-A", "HolderOriginA");
        public static WinFormsField OriginAStatus = new WinFormsField("ORIGIN-A-STATUS", "OriginAStatus");
        public static WinFormsField HolderOriginN = new WinFormsField("HOLDER-ORIGIN-N", "HolderOriginN");
        public static WinFormsField OriginNStatus = new WinFormsField("ORIGIN-N-STATUS", "OriginNStatus");
        public static WinFormsField FasterScriplessNbr = new WinFormsField("FASTER-SCRIPLESS-NBR", "FasterScriplessNbr");
        public static WinFormsField HolderOriginB = new WinFormsField("HOLDER-ORIGIN-B", "HolderOriginB");
        public static WinFormsField OriginBStatus = new WinFormsField("ORIGIN-B-STATUS", "OriginBStatus");
        public static WinFormsField HolderOriginO = new WinFormsField("HOLDER-ORIGIN-O", "HolderOriginO");
        public static WinFormsField OriginOStatus = new WinFormsField("ORIGIN-O-STATUS", "OriginOStatus");
        public static WinFormsField HolderOriginC = new WinFormsField("HOLDER-ORIGIN-C", "HolderOriginC");
        public static WinFormsField OriginCStatus = new WinFormsField("ORIGIN-C-STATUS", "OriginCStatus");
        public static WinFormsField HolderOriginP = new WinFormsField("HOLDER-ORIGIN-P", "HolderOriginP");
        public static WinFormsField OriginPStatus = new WinFormsField("ORIGIN-P-STATUS", "OriginPStatus");
        public static WinFormsField HolderOriginD = new WinFormsField("HOLDER-ORIGIN-D", "HolderOriginD");
        public static WinFormsField OriginDStatus = new WinFormsField("ORIGIN-D-STATUS", "OriginDStatus");
        public static WinFormsField HolderOriginQ = new WinFormsField("HOLDER-ORIGIN-Q", "HolderOriginQ");
        public static WinFormsField OriginQStatus = new WinFormsField("ORIGIN-Q-STATUS", "OriginQStatus");
        public static WinFormsField CosmosUploadInd = new WinFormsField("COSMOS-UPLOAD-IND", "CosmosUploadInd");
        public static WinFormsField HolderOriginE = new WinFormsField("HOLDER-ORIGIN-E", "HolderOriginE");
        public static WinFormsField OriginEStatus = new WinFormsField("ORIGIN-E-STATUS", "OriginEStatus");
        public static WinFormsField HolderOriginR = new WinFormsField("HOLDER-ORIGIN-R", "HolderOriginR");
        public static WinFormsField OriginRStatus = new WinFormsField("ORIGIN-R-STATUS", "OriginRStatus");
        public static WinFormsField LstRunCosmosUpload = new WinFormsField("LST-RUN-COSMOS-UPLOAD", "LstRunCosmosUpload");
        public static WinFormsField HolderOriginF = new WinFormsField("HOLDER-ORIGIN-F", "HolderOriginF");
        public static WinFormsField OriginFStatus = new WinFormsField("ORIGIN-F-STATUS", "OriginFStatus");
        public static WinFormsField HolderOriginS = new WinFormsField("HOLDER-ORIGIN-S", "HolderOriginS");
        public static WinFormsField OriginSStatus = new WinFormsField("ORIGIN-S-STATUS", "OriginSStatus");
        public static WinFormsField LstTranCosmosUpload = new WinFormsField("LST-TRAN-COSMOS-UPLOAD", "LstTranCosmosUpload");
        public static WinFormsField HolderOriginG = new WinFormsField("HOLDER-ORIGIN-G", "HolderOriginG");
        public static WinFormsField OriginGStatus = new WinFormsField("ORIGIN-G-STATUS", "OriginGStatus");
        public static WinFormsField HolderOriginT = new WinFormsField("HOLDER-ORIGIN-T", "HolderOriginT");
        public static WinFormsField OriginTStatus = new WinFormsField("ORIGIN-T-STATUS", "OriginTStatus");
        public static WinFormsField LstRecCosmosUpload = new WinFormsField("LST-REC-COSMOS-UPLOAD", "LstRecCosmosUpload");
        public static WinFormsField HolderOriginH = new WinFormsField("HOLDER-ORIGIN-H", "HolderOriginH");
        public static WinFormsField OriginHStatus = new WinFormsField("ORIGIN-H-STATUS", "OriginHStatus");
        public static WinFormsField HolderOriginU = new WinFormsField("HOLDER-ORIGIN-U", "HolderOriginU");
        public static WinFormsField OriginUStatus = new WinFormsField("ORIGIN-U-STATUS", "OriginUStatus");
        public static WinFormsField HolderOriginI = new WinFormsField("HOLDER-ORIGIN-I", "HolderOriginI");
        public static WinFormsField OriginIStatus = new WinFormsField("ORIGIN-I-STATUS", "OriginIStatus");
        public static WinFormsField HolderOriginV = new WinFormsField("HOLDER-ORIGIN-V", "HolderOriginV");
        public static WinFormsField OriginVStatus = new WinFormsField("ORIGIN-V-STATUS", "OriginVStatus");
        public static WinFormsField HolderOriginJ = new WinFormsField("HOLDER-ORIGIN-J", "HolderOriginJ");
        public static WinFormsField OriginJStatus = new WinFormsField("ORIGIN-J-STATUS", "OriginJStatus");
        public static WinFormsField HolderOriginW = new WinFormsField("HOLDER-ORIGIN-W", "HolderOriginW");
        public static WinFormsField OriginWStatus = new WinFormsField("ORIGIN-W-STATUS", "OriginWStatus");
        public static WinFormsField HolderOriginK = new WinFormsField("HOLDER-ORIGIN-K", "HolderOriginK");
        public static WinFormsField OriginKStatus = new WinFormsField("ORIGIN-K-STATUS", "OriginKStatus");
        public static WinFormsField HolderOriginX = new WinFormsField("HOLDER-ORIGIN-X", "HolderOriginX");
        public static WinFormsField OriginXStatus = new WinFormsField("ORIGIN-X-STATUS", "OriginXStatus");
        public static WinFormsField ChessUic = new WinFormsField("CHESS-UIC", "ChessUic");
        public static WinFormsField HolderOriginL = new WinFormsField("HOLDER-ORIGIN-L", "HolderOriginL");
        public static WinFormsField OriginLStatus = new WinFormsField("ORIGIN-L-STATUS", "OriginLStatus");
        public static WinFormsField HolderOriginY = new WinFormsField("HOLDER-ORIGIN-Y", "HolderOriginY");
        public static WinFormsField OriginYStatus = new WinFormsField("ORIGIN-Y-STATUS", "OriginYStatus");
        public static WinFormsField HolderOriginM = new WinFormsField("HOLDER-ORIGIN-M", "HolderOriginM");
        public static WinFormsField OriginMStatus = new WinFormsField("ORIGIN-M-STATUS", "OriginMStatus");
        public static WinFormsField HolderOriginZ = new WinFormsField("HOLDER-ORIGIN-Z", "HolderOriginZ");
        public static WinFormsField OriginZStatus = new WinFormsField("ORIGIN-Z-STATUS", "OriginZStatus");
        public static WinFormsField CrestBadDeliverInd = new WinFormsField("CREST-BAD-DELIVER-IND", "CrestBadDeliverInd");
        public static WinFormsField EmailAddressA = new WinFormsField("EMAIL-ADDRESS-A", "EmailAddressA");
        public static WinFormsField EmailAddressB = new WinFormsField("EMAIL-ADDRESS-B", "EmailAddressB");
        public static WinFormsField ForeignCharsInd = new WinFormsField("FOREIGN-CHARS-IND", "ForeignCharsInd");
    }
}
