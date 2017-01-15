using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTS02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTS02001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField NoticesSource = new WinFormsField("NOTICES-SOURCE", "NoticesSource");
        public static WinFormsField InputFileName = new WinFormsField("INPUT-FILE-NAME", "InputFileName");
        public static WinFormsField HolderTypeRS = new WinFormsField("HOLDER-TYPE-RS", "HolderTypeRS");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField SpecialProgramName = new WinFormsField("SPECIAL-PROGRAM-NAME", "SpecialProgramName");
        public static WinFormsField NoticeFormat = new WinFormsField("NOTICE-FORMAT", "NoticeFormat");
        public static WinFormsField PrintCompany = new WinFormsField("PRINT-COMPANY", "PrintCompany");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
