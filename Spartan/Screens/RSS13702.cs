using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS13702", "FormName");
		//Fields


        public static WinFormsField PeriodMM = new WinFormsField("PERIOD-MM", "PeriodMM");
        public static WinFormsField PeriodYY = new WinFormsField("PERIOD-YY", "PeriodYY");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField Directory = new WinFormsField("DIRECTORY", "Directory");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
