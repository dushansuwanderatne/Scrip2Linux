using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRNCDE01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRNCDE01", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField TrncdeKey0 = new WinFormsField("TRNCDE-KEY0", "TrncdeKey0");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeClass = new WinFormsField("TRAN-TYPE-CLASS", "TranTypeClass");
        public static WinFormsField TranTypeProcess = new WinFormsField("TRAN-TYPE-PROCESS", "TranTypeProcess");
        public static WinFormsField TranTypeList = new WinFormsField("TRAN-TYPE-LIST", "TranTypeList");
        public static WinFormsField TranTypeAnalysis = new WinFormsField("TRAN-TYPE-ANALYSIS", "TranTypeAnalysis");
        public static WinFormsField TranTypeGroup = new WinFormsField("TRAN-TYPE-GROUP", "TranTypeGroup");
        public static WinFormsField TranScripOption = new WinFormsField("TRAN-SCRIP-OPTION", "TranScripOption");
        public static WinFormsField TranFromTOFlag = new WinFormsField("TRAN-FROM-TO-FLAG", "TranFromTOFlag");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TranTypeAlt = new WinFormsField("TRAN-TYPE-ALT", "TranTypeAlt");
        public static WinFormsField TranTypeCurrency = new WinFormsField("TRAN-TYPE-CURRENCY", "TranTypeCurrency");
        public static WinFormsField TranBillingGroup = new WinFormsField("TRAN-BILLING-GROUP", "TranBillingGroup");
        public static WinFormsField Y00n00 = new WinFormsField("Y00N00", "Y00n00");
        public static WinFormsField TranTypeOrigin = new WinFormsField("TRAN-TYPE-ORIGIN", "TranTypeOrigin");
    }
}
