using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01014

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01014", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField LastRunDate = new WinFormsField("LAST-RUN-DATE", "LastRunDate");
        public static WinFormsField DumpRun = new WinFormsField("DUMP-RUN", "DumpRun");
        public static WinFormsField Node = new WinFormsField("NODE", "Node");
        public static WinFormsField HolderCategory = new WinFormsField("HOLDER-CATEGORY", "HolderCategory");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
