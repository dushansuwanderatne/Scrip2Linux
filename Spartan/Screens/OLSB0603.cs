using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0603

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0603", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OrderNO = new WinFormsField("ORDER-NO", "OrderNO");
        public static WinFormsField Ident = new WinFormsField("IDENT", "Ident");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
    }
}
