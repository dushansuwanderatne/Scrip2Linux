using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01032

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01032", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField Heading1 = new WinFormsField("HEADING-1", "Heading1");
        public static WinFormsField Heading2 = new WinFormsField("HEADING-2", "Heading2");
        public static WinFormsField Heading3 = new WinFormsField("HEADING-3", "Heading3");
        public static WinFormsField Heading4 = new WinFormsField("HEADING-4", "Heading4");
        public static WinFormsField DivRate = new WinFormsField("DIV-RATE", "DivRate");
        public static WinFormsField RateAmt1 = new WinFormsField("RATE-AMT1", "RateAmt1");
        public static WinFormsField RateAmt2 = new WinFormsField("RATE-AMT2", "RateAmt2");
        public static WinFormsField RateAmt3 = new WinFormsField("RATE-AMT3", "RateAmt3");
    }
}
