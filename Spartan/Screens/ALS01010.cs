using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField PrintHolderID = new WinFormsField("PRINT-HOLDER-ID", "PrintHolderID");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField XtrFilname = new WinFormsField("XTR-FILNAME", "XtrFilname");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField AlternateIDPrint = new WinFormsField("ALTERNATE-ID-PRINT", "AlternateIDPrint");
        public static WinFormsField CalcProgName = new WinFormsField("CALC-PROG-NAME", "CalcProgName");
        public static WinFormsField AllotmentType = new WinFormsField("ALLOTMENT-TYPE", "AllotmentType");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
