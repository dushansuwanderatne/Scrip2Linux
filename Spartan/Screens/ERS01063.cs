using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01063

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01063", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField AmendmentInd = new WinFormsField("AMENDMENT-IND", "AmendmentInd");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField AtoFileInd = new WinFormsField("ATO-FILE-IND", "AtoFileInd");
        public static WinFormsField PlanType = new WinFormsField("PLAN-TYPE", "PlanType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
