using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOLB0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOLB0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDescription = new WinFormsField("TRAN-TYPE-DESCRIPTION", "TranTypeDescription");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField BulkTranType = new WinFormsField("BULK-TRAN-TYPE", "BulkTranType");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField GenerateAdvices = new WinFormsField("GENERATE-ADVICES", "GenerateAdvices");
        public static WinFormsField SpecialAdviceProgram = new WinFormsField("SPECIAL-ADVICE-PROGRAM", "SpecialAdviceProgram");
        public static WinFormsField GenerateCerts = new WinFormsField("GENERATE-CERTS", "GenerateCerts");
        public static WinFormsField CounterContDetails = new WinFormsField("COUNTER-CONT-DETAILS", "CounterContDetails");
        public static WinFormsField CounterTranType = new WinFormsField("COUNTER-TRAN-TYPE", "CounterTranType");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField AuditInd = new WinFormsField("AUDIT-IND", "AuditInd");
        public static WinFormsField AuditSettlingTrans = new WinFormsField("AUDIT-SETTLING-TRANS", "AuditSettlingTrans");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
