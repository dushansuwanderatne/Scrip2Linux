using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS20019

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS20019", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ReportIDCode = new WinFormsField("REPORT-ID-CODE", "ReportIDCode");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
