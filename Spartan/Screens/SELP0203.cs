using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELP0203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELP0203", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ControlAccountFlag = new WinFormsField("CONTROL-ACCOUNT-FLAG", "ControlAccountFlag");
        public static WinFormsField ControlHolderID = new WinFormsField("CONTROL-HOLDER-ID", "ControlHolderID");
        public static WinFormsField ReserveAccountFlag = new WinFormsField("RESERVE-ACCOUNT-FLAG", "ReserveAccountFlag");
        public static WinFormsField ReserveHolderID = new WinFormsField("RESERVE-HOLDER-ID", "ReserveHolderID");
        public static WinFormsField ReserveValueClass = new WinFormsField("RESERVE-VALUE-CLASS", "ReserveValueClass");
        public static WinFormsField PrintDivision = new WinFormsField("PRINT-DIVISION", "PrintDivision");
        public static WinFormsField DivisionFlag1 = new WinFormsField("DIVISION-FLAG1", "DivisionFlag1");
        public static WinFormsField DivisionFlag2 = new WinFormsField("DIVISION-FLAG2", "DivisionFlag2");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField NoticeFormat = new WinFormsField("NOTICE-FORMAT", "NoticeFormat");
        public static WinFormsField NoticeSeq = new WinFormsField("NOTICE-SEQ", "NoticeSeq");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
