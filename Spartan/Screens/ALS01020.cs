using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01020", "FormName");
		//Fields


        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField Selreg01 = new WinFormsField("SELREG01", "Selreg01");
        public static WinFormsField Selreg02 = new WinFormsField("SELREG02", "Selreg02");
        public static WinFormsField Selreg03 = new WinFormsField("SELREG03", "Selreg03");
        public static WinFormsField Selreg04 = new WinFormsField("SELREG04", "Selreg04");
        public static WinFormsField Selreg05 = new WinFormsField("SELREG05", "Selreg05");
        public static WinFormsField Selreg06 = new WinFormsField("SELREG06", "Selreg06");
        public static WinFormsField Selreg07 = new WinFormsField("SELREG07", "Selreg07");
        public static WinFormsField Selreg08 = new WinFormsField("SELREG08", "Selreg08");
        public static WinFormsField Selreg09 = new WinFormsField("SELREG09", "Selreg09");
        public static WinFormsField Selreg10 = new WinFormsField("SELREG10", "Selreg10");
        public static WinFormsField DeductSelcls = new WinFormsField("DEDUCT-SELCLS", "DeductSelcls");
        public static WinFormsField ReductionTranCode = new WinFormsField("REDUCTION-TRAN-CODE", "ReductionTranCode");
        public static WinFormsField ScripReq = new WinFormsField("SCRIP-REQ", "ScripReq");
        public static WinFormsField ChessCompanyFlag = new WinFormsField("CHESS-COMPANY-FLAG", "ChessCompanyFlag");
        public static WinFormsField FirstAltClass = new WinFormsField("FIRST-ALT-CLASS", "FirstAltClass");
        public static WinFormsField SecondAltClass = new WinFormsField("SECOND-ALT-CLASS", "SecondAltClass");
        public static WinFormsField RetainCN = new WinFormsField("RETAIN-CN", "RetainCN");
        public static WinFormsField RetainCNDate = new WinFormsField("RETAIN-CN-DATE", "RetainCNDate");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField CertInd = new WinFormsField("CERT-IND", "CertInd");
        public static WinFormsField AllotmentRegister = new WinFormsField("ALLOTMENT-REGISTER", "AllotmentRegister");
        public static WinFormsField NspRequiredInd = new WinFormsField("NSP-REQUIRED-IND", "NspRequiredInd");
        public static WinFormsField EomSelectionCode = new WinFormsField("EOM-SELECTION-CODE", "EomSelectionCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
