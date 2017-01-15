using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField ToleranceAmount = new WinFormsField("TOLERANCE-AMOUNT", "ToleranceAmount");
        public static WinFormsField RvsalRunNumber = new WinFormsField("RVSAL-RUN-NUMBER", "RvsalRunNumber");
        public static WinFormsField RvsalTransNumber = new WinFormsField("RVSAL-TRANS-NUMBER", "RvsalTransNumber");
        public static WinFormsField RvsalTranTypeDesc = new WinFormsField("RVSAL-TRAN-TYPE-DESC", "RvsalTranTypeDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField CalctlNum = new WinFormsField("CALCTL-NUM", "CalctlNum");
        public static WinFormsField CallDescription = new WinFormsField("CALL-DESCRIPTION", "CallDescription");
        public static WinFormsField FromClassDesc = new WinFormsField("FROM-CLASS-DESC", "FromClassDesc");
        public static WinFormsField TOClassDesc = new WinFormsField("TO-CLASS-DESC", "TOClassDesc");
        public static WinFormsField FromHin = new WinFormsField("FROM-HIN", "FromHin");
        public static WinFormsField FromHnaLine = new WinFormsField("FROM-HNA-LINE", "FromHnaLine");
        public static WinFormsField RvsalFromTradeRef = new WinFormsField("RVSAL-FROM-TRADE-REF", "RvsalFromTradeRef");
        public static WinFormsField RvsalConfirm = new WinFormsField("RVSAL-CONFIRM", "RvsalConfirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
