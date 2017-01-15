using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01028

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01028", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField GroupNumber = new WinFormsField("GROUP-NUMBER", "GroupNumber");
        public static WinFormsField MCDomCode = new WinFormsField("MC-DOM-CODE", "MCDomCode");
        public static WinFormsField MCConversionRate = new WinFormsField("MC-CONVERSION-RATE", "MCConversionRate");
        public static WinFormsField MCConversionDesc = new WinFormsField("MC-CONVERSION-DESC", "MCConversionDesc");
        public static WinFormsField MCBuildOption = new WinFormsField("MC-BUILD-OPTION", "MCBuildOption");
        public static WinFormsField MCPayAccountNbr = new WinFormsField("MC-PAY-ACCOUNT-NBR", "MCPayAccountNbr");
        public static WinFormsField MCChequeDescWords = new WinFormsField("MC-CHEQUE-DESC-WORDS", "MCChequeDescWords");
        public static WinFormsField MCCplOpt = new WinFormsField("MC-CPL-OPT", "MCCplOpt");
        public static WinFormsField MCChequeCplName = new WinFormsField("MC-CHEQUE-CPL-NAME", "MCChequeCplName");
        public static WinFormsField ScreenChequeFormat = new WinFormsField("SCREEN-CHEQUE-FORMAT", "ScreenChequeFormat");
        public static WinFormsField MCStartRefNumber = new WinFormsField("MC-START-REF-NUMBER", "MCStartRefNumber");
        public static WinFormsField MCLowerCommentLine = new WinFormsField("MC-LOWER-COMMENT-LINE", "MCLowerCommentLine");
    }
}
