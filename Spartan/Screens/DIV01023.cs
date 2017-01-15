using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01023

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01023", "FormName");
		//Fields


        public static WinFormsField PaymentBuildReq = new WinFormsField("PAYMENT-BUILD-REQ", "PaymentBuildReq");
        public static WinFormsField TwinDivAcct = new WinFormsField("TWIN-DIV-ACCT", "TwinDivAcct");
        public static WinFormsField TwinSplitAcct = new WinFormsField("TWIN-SPLIT-ACCT", "TwinSplitAcct");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField MinPmentInd = new WinFormsField("MIN-PMENT-IND", "MinPmentInd");
        public static WinFormsField MinPmentAmt = new WinFormsField("MIN-PMENT-AMT", "MinPmentAmt");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField DIDCApply = new WinFormsField("DI-DC-APPLY", "DIDCApply");
        public static WinFormsField PayMandtryDcr = new WinFormsField("PAY-MANDTRY-DCR", "PayMandtryDcr");
        public static WinFormsField MandtryDcrDom = new WinFormsField("MANDTRY-DCR-DOM", "MandtryDcrDom");
        public static WinFormsField CoyNamePrint = new WinFormsField("COY-NAME-PRINT", "CoyNamePrint");
        public static WinFormsField DidcStartRef = new WinFormsField("DIDC-START-REF", "DidcStartRef");
        public static WinFormsField DISortFlag = new WinFormsField("DI-SORT-FLAG", "DISortFlag");
        public static WinFormsField DCTapeDate = new WinFormsField("DC-TAPE-DATE", "DCTapeDate");
        public static WinFormsField SeparateBulk = new WinFormsField("SEPARATE-BULK", "SeparateBulk");
        public static WinFormsField AdvUpperPrint = new WinFormsField("ADV-UPPER-PRINT", "AdvUpperPrint");
        public static WinFormsField AdvLowerPrint = new WinFormsField("ADV-LOWER-PRINT", "AdvLowerPrint");
        public static WinFormsField AdvExtraOptComment = new WinFormsField("ADV-EXTRA-OPT-COMMENT", "AdvExtraOptComment");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
