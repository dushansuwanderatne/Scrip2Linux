using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SSRP0601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SSRP0601", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField Mode = new WinFormsField("MODE", "Mode");
        public static WinFormsField Vfs = new WinFormsField("VFS", "Vfs");
        public static WinFormsField TransCode = new WinFormsField("TRANS-CODE", "TransCode");
        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
