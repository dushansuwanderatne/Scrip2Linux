using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS05000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS05000", "FormName");
		//Fields


        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField OrderNO = new WinFormsField("ORDER-NO", "OrderNO");
        public static WinFormsField Ident = new WinFormsField("IDENT", "Ident");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField PrintFilename = new WinFormsField("PRINT-FILENAME", "PrintFilename");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
