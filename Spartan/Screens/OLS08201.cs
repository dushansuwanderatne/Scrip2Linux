using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField ValidationDate = new WinFormsField("VALIDATION-DATE", "ValidationDate");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField FromTOHeading = new WinFormsField("FROM-TO-HEADING", "FromTOHeading");
        public static WinFormsField CallNumber = new WinFormsField("CALL-NUMBER", "CallNumber");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField NoticeNumber = new WinFormsField("NOTICE-NUMBER", "NoticeNumber");
        public static WinFormsField Holder = new WinFormsField("HOLDER", "Holder");
        public static WinFormsField DishonorResult = new WinFormsField("DISHONOR-RESULT", "DishonorResult");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
