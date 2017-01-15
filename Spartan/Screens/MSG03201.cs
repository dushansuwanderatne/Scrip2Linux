using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG03201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG03201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField Events1 = new WinFormsField("EVENTS-1", "Events1");
        public static WinFormsField Events2 = new WinFormsField("EVENTS-2", "Events2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
