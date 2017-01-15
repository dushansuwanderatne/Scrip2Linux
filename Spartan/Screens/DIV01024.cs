using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01024

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01024", "FormName");
		//Fields


        public static WinFormsField SpecialChequeCpl = new WinFormsField("SPECIAL-CHEQUE-CPL", "SpecialChequeCpl");
        public static WinFormsField ChequeCplName = new WinFormsField("CHEQUE-CPL-NAME", "ChequeCplName");
        public static WinFormsField ChequeFormat = new WinFormsField("CHEQUE-FORMAT", "ChequeFormat");
        public static WinFormsField ChequeStartRef = new WinFormsField("CHEQUE-START-REF", "ChequeStartRef");
        public static WinFormsField HidPrint = new WinFormsField("HID-PRINT", "HidPrint");
        public static WinFormsField AdviceFormat = new WinFormsField("ADVICE-FORMAT", "AdviceFormat");
        public static WinFormsField UnitsPrint = new WinFormsField("UNITS-PRINT", "UnitsPrint");
        public static WinFormsField TaxDescPrint = new WinFormsField("TAX-DESC-PRINT", "TaxDescPrint");
        public static WinFormsField ExtraOptComment = new WinFormsField("EXTRA-OPT-COMMENT", "ExtraOptComment");
        public static WinFormsField ChequeDescWords = new WinFormsField("CHEQUE-DESC-WORDS", "ChequeDescWords");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
