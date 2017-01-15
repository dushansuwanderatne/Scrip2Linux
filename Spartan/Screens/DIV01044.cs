using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01044

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01044", "FormName");
		//Fields


        public static WinFormsField DIDCApply = new WinFormsField("DI-DC-APPLY", "DIDCApply");
        public static WinFormsField CoyNamePrint = new WinFormsField("COY-NAME-PRINT", "CoyNamePrint");
        public static WinFormsField DidcStartRef = new WinFormsField("DIDC-START-REF", "DidcStartRef");
        public static WinFormsField AdviceFormat2 = new WinFormsField("ADVICE-FORMAT-2", "AdviceFormat2");
        public static WinFormsField DCTapeDate = new WinFormsField("DC-TAPE-DATE", "DCTapeDate");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
