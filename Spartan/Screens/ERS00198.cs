using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00198

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00198", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ProcessCompany = new WinFormsField("PROCESS-COMPANY", "ProcessCompany");
        public static WinFormsField SchemeType = new WinFormsField("SCHEME-TYPE", "SchemeType");
        public static WinFormsField ProcessDateFrom = new WinFormsField("PROCESS-DATE-FROM", "ProcessDateFrom");
        public static WinFormsField ProcessDateTO = new WinFormsField("PROCESS-DATE-TO", "ProcessDateTO");
    }
}
