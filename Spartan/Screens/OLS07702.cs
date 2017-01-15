using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS07702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS07702", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField RvsalRunNumber = new WinFormsField("RVSAL-RUN-NUMBER", "RvsalRunNumber");
        public static WinFormsField RvsalTransNumber = new WinFormsField("RVSAL-TRANS-NUMBER", "RvsalTransNumber");
        public static WinFormsField RvsalTranTypeDesc = new WinFormsField("RVSAL-TRAN-TYPE-DESC", "RvsalTranTypeDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField RvsalFromCertID = new WinFormsField("RVSAL-FROM-CERT-ID", "RvsalFromCertID");
        public static WinFormsField RvsalTOCertID = new WinFormsField("RVSAL-TO-CERT-ID", "RvsalTOCertID");
        public static WinFormsField FromClassDesc = new WinFormsField("FROM-CLASS-DESC", "FromClassDesc");
        public static WinFormsField TOClassDesc = new WinFormsField("TO-CLASS-DESC", "TOClassDesc");
        public static WinFormsField FromRegisterDesc = new WinFormsField("FROM-REGISTER-DESC", "FromRegisterDesc");
        public static WinFormsField TORegisterDesc = new WinFormsField("TO-REGISTER-DESC", "TORegisterDesc");
        public static WinFormsField FromHin = new WinFormsField("FROM-HIN", "FromHin");
        public static WinFormsField TOHin = new WinFormsField("TO-HIN", "TOHin");
        public static WinFormsField FromHnaLine = new WinFormsField("FROM-HNA-LINE", "FromHnaLine");
        public static WinFormsField TOHnaLine = new WinFormsField("TO-HNA-LINE", "TOHnaLine");
        public static WinFormsField RvsalFromTradeRef = new WinFormsField("RVSAL-FROM-TRADE-REF", "RvsalFromTradeRef");
        public static WinFormsField RvsalTOTradeRef = new WinFormsField("RVSAL-TO-TRADE-REF", "RvsalTOTradeRef");
        public static WinFormsField RvsalConfirm = new WinFormsField("RVSAL-CONFIRM", "RvsalConfirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
