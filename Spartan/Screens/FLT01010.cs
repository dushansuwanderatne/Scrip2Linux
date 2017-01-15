using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLT01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLT01010", "FormName");
		//Fields


        public static WinFormsField FloatStatusInd = new WinFormsField("FLOAT-STATUS-IND", "FloatStatusInd");
        public static WinFormsField FloatMenuFormName = new WinFormsField("FLOAT-MENU-FORM-NAME", "FloatMenuFormName");
        public static WinFormsField OnlineBatchInd = new WinFormsField("ONLINE-BATCH-IND", "OnlineBatchInd");
        public static WinFormsField HolderCategory = new WinFormsField("HOLDER-CATEGORY", "HolderCategory");
        public static WinFormsField AutoIncrementNbr = new WinFormsField("AUTO-INCREMENT-NBR", "AutoIncrementNbr");
        public static WinFormsField FastProcessing = new WinFormsField("FAST-PROCESSING", "FastProcessing");
        public static WinFormsField RemittanceInd = new WinFormsField("REMITTANCE-IND", "RemittanceInd");
        public static WinFormsField ReceiptRoutingID = new WinFormsField("RECEIPT-ROUTING-ID", "ReceiptRoutingID");
        public static WinFormsField SingleFloatCoyInd = new WinFormsField("SINGLE-FLOAT-COY-IND", "SingleFloatCoyInd");
        public static WinFormsField ProjectID = new WinFormsField("PROJECT-ID", "ProjectID");
        public static WinFormsField CheckDigitApplInd = new WinFormsField("CHECK-DIGIT-APPL-IND", "CheckDigitApplInd");
        public static WinFormsField CheckDigitType = new WinFormsField("CHECK-DIGIT-TYPE", "CheckDigitType");
        public static WinFormsField CheckDigitUserCode = new WinFormsField("CHECK-DIGIT-USER-CODE", "CheckDigitUserCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
