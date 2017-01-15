using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01024

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01024", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SpecialChequeArl = new WinFormsField("SPECIAL-CHEQUE-ARL", "SpecialChequeArl");
        public static WinFormsField ChequeArlName = new WinFormsField("CHEQUE-ARL-NAME", "ChequeArlName");
        public static WinFormsField ChequeFormat = new WinFormsField("CHEQUE-FORMAT", "ChequeFormat");
        public static WinFormsField AdviceFormat = new WinFormsField("ADVICE-FORMAT", "AdviceFormat");
        public static WinFormsField ChequeStartRef = new WinFormsField("CHEQUE-START-REF", "ChequeStartRef");
        public static WinFormsField HolderIDPrint = new WinFormsField("HOLDER-ID-PRINT", "HolderIDPrint");
        public static WinFormsField TaxDescPrint = new WinFormsField("TAX-DESC-PRINT", "TaxDescPrint");
        public static WinFormsField ChequeDescWords = new WinFormsField("CHEQUE-DESC-WORDS", "ChequeDescWords");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
