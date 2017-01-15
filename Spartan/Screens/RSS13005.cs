using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS13005", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Companies = new WinFormsField("COMPANIES", "Companies");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
        public static WinFormsField DateORRunNumberInd = new WinFormsField("DATE-OR-RUN-NUMBER-IND", "DateORRunNumberInd");
        public static WinFormsField PeriodMmyy = new WinFormsField("PERIOD-MMYY", "PeriodMmyy");
        public static WinFormsField RunNumberFrom = new WinFormsField("RUN-NUMBER-FROM", "RunNumberFrom");
        public static WinFormsField RunNumberTO = new WinFormsField("RUN-NUMBER-TO", "RunNumberTO");
    }
}
