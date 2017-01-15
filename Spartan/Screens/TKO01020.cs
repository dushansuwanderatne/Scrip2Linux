using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01020", "FormName");
		//Fields


        public static WinFormsField NoticeListHeading = new WinFormsField("NOTICE-LIST-HEADING", "NoticeListHeading");
        public static WinFormsField EntReportDate = new WinFormsField("ENT-REPORT-DATE", "EntReportDate");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField XtractFilnam = new WinFormsField("XTRACT-FILNAM", "XtractFilnam");
        public static WinFormsField SpecialPrint = new WinFormsField("SPECIAL-PRINT", "SpecialPrint");
        public static WinFormsField NoticeProgName = new WinFormsField("NOTICE-PROG-NAME", "NoticeProgName");
        public static WinFormsField NoticeFormat = new WinFormsField("NOTICE-FORMAT", "NoticeFormat");
        public static WinFormsField NoticeSequence = new WinFormsField("NOTICE-SEQUENCE", "NoticeSequence");
        public static WinFormsField ReturnMailInd = new WinFormsField("RETURN-MAIL-IND", "ReturnMailInd");
        public static WinFormsField NoticePrintLevel = new WinFormsField("NOTICE-PRINT-LEVEL", "NoticePrintLevel");
        public static WinFormsField PrintRegisterDesc = new WinFormsField("PRINT-REGISTER-DESC", "PrintRegisterDesc");
        public static WinFormsField PrintClassDesc = new WinFormsField("PRINT-CLASS-DESC", "PrintClassDesc");
        public static WinFormsField SupplementaryNot = new WinFormsField("SUPPLEMENTARY-NOT", "SupplementaryNot");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
