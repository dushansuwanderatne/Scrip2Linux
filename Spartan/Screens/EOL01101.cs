using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField RegDesc = new WinFormsField("REG-DESC", "RegDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField RvsalRunNumber = new WinFormsField("RVSAL-RUN-NUMBER", "RvsalRunNumber");
        public static WinFormsField RvsalTransNumber = new WinFormsField("RVSAL-TRANS-NUMBER", "RvsalTransNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Usan = new WinFormsField("USAN", "Usan");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentAmount = new WinFormsField("PAYMENT-AMOUNT", "PaymentAmount");
        public static WinFormsField StatusFlag = new WinFormsField("STATUS-FLAG", "StatusFlag");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
