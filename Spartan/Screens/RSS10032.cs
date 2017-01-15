using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10032

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10032", "FormName");
		//Fields


        public static WinFormsField TaxCodeFlag = new WinFormsField("TAX-CODE-FLAG", "TaxCodeFlag");
        public static WinFormsField OtaxCodes = new WinFormsField("OTAX-CODES", "OtaxCodes");
        public static WinFormsField NzlIrds = new WinFormsField("NZL-IRDS", "NzlIrds");
        public static WinFormsField NzlExempt = new WinFormsField("NZL-EXEMPT", "NzlExempt");
        public static WinFormsField TfnFlag = new WinFormsField("TFN-FLAG", "TfnFlag");
        public static WinFormsField TfnQuotedFlag = new WinFormsField("TFN-QUOTED-FLAG", "TfnQuotedFlag");
        public static WinFormsField ExemptCode = new WinFormsField("EXEMPT-CODE", "ExemptCode");
        public static WinFormsField TfnNotQuotedFlag = new WinFormsField("TFN-NOT-QUOTED-FLAG", "TfnNotQuotedFlag");
        public static WinFormsField JointIncompleteInd = new WinFormsField("JOINT-INCOMPLETE-IND", "JointIncompleteInd");
        public static WinFormsField TinType = new WinFormsField("TIN-TYPE", "TinType");
        public static WinFormsField TinStatusNbr = new WinFormsField("TIN-STATUS-NBR", "TinStatusNbr");
        public static WinFormsField TinExpiryDateFrom = new WinFormsField("TIN-EXPIRY-DATE-FROM", "TinExpiryDateFrom");
        public static WinFormsField TinExpiryDateTO = new WinFormsField("TIN-EXPIRY-DATE-TO", "TinExpiryDateTO");
        public static WinFormsField TinCertifiedInd = new WinFormsField("TIN-CERTIFIED-IND", "TinCertifiedInd");
        public static WinFormsField HolderParentIdent = new WinFormsField("HOLDER-PARENT-IDENT", "HolderParentIdent");
        public static WinFormsField USTaxCodeFlag = new WinFormsField("US-TAX-CODE-FLAG", "USTaxCodeFlag");
        public static WinFormsField USOtaxCodes = new WinFormsField("US-OTAX-CODES", "USOtaxCodes");
        public static WinFormsField AccountTypeFlag = new WinFormsField("ACCOUNT-TYPE-FLAG", "AccountTypeFlag");
        public static WinFormsField AccountType = new WinFormsField("ACCOUNT-TYPE", "AccountType");
        public static WinFormsField PreexCodeFlag = new WinFormsField("PREEX-CODE-FLAG", "PreexCodeFlag");
        public static WinFormsField PreexCode = new WinFormsField("PREEX-CODE", "PreexCode");
        public static WinFormsField CuringStatusFlag = new WinFormsField("CURING-STATUS-FLAG", "CuringStatusFlag");
        public static WinFormsField CuringStatus = new WinFormsField("CURING-STATUS", "CuringStatus");
        public static WinFormsField ValueStatusFlag = new WinFormsField("VALUE-STATUS-FLAG", "ValueStatusFlag");
        public static WinFormsField ValueStatus = new WinFormsField("VALUE-STATUS", "ValueStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
