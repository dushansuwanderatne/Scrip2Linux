using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01023

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01023", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PaymentBuildReq = new WinFormsField("PAYMENT-BUILD-REQ", "PaymentBuildReq");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField AutoRedemptionInd = new WinFormsField("AUTO-REDEMPTION-IND", "AutoRedemptionInd");
        public static WinFormsField AutoRedemptionTran = new WinFormsField("AUTO-REDEMPTION-TRAN", "AutoRedemptionTran");
        public static WinFormsField DIDCApplyPM = new WinFormsField("DI-DC-APPLY-PM", "DIDCApplyPM");
        public static WinFormsField DIDCApplyIL = new WinFormsField("DI-DC-APPLY-IL", "DIDCApplyIL");
        public static WinFormsField CoyNamePrint = new WinFormsField("COY-NAME-PRINT", "CoyNamePrint");
        public static WinFormsField DidcStartRef = new WinFormsField("DIDC-START-REF", "DidcStartRef");
        public static WinFormsField DISortFlag = new WinFormsField("DI-SORT-FLAG", "DISortFlag");
        public static WinFormsField DCTapeDate = new WinFormsField("DC-TAPE-DATE", "DCTapeDate");
        public static WinFormsField SeparateBulk = new WinFormsField("SEPARATE-BULK", "SeparateBulk");
        public static WinFormsField ProduceDcbTape = new WinFormsField("PRODUCE-DCB-TAPE", "ProduceDcbTape");
        public static WinFormsField ProduceHomeDcbTape = new WinFormsField("PRODUCE-HOME-DCB-TAPE", "ProduceHomeDcbTape");
        public static WinFormsField SgbCommentLayout = new WinFormsField("SGB-COMMENT-LAYOUT", "SgbCommentLayout");
        public static WinFormsField AdvLowerPrint = new WinFormsField("ADV-LOWER-PRINT", "AdvLowerPrint");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
