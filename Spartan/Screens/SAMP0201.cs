using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SAMP0201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SAMP0201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField RepDesc = new WinFormsField("REP-DESC", "RepDesc");
        public static WinFormsField ReportSequence = new WinFormsField("REPORT-SEQUENCE", "ReportSequence");
        public static WinFormsField TermDateFrom = new WinFormsField("TERM-DATE-FROM", "TermDateFrom");
        public static WinFormsField TermDateTO = new WinFormsField("TERM-DATE-TO", "TermDateTO");
        public static WinFormsField PayrollSystem1 = new WinFormsField("PAYROLL-SYSTEM1", "PayrollSystem1");
        public static WinFormsField PayrollSystem2 = new WinFormsField("PAYROLL-SYSTEM2", "PayrollSystem2");
        public static WinFormsField PayrollSystem3 = new WinFormsField("PAYROLL-SYSTEM3", "PayrollSystem3");
        public static WinFormsField TerminationType = new WinFormsField("TERMINATION-TYPE", "TerminationType");
        public static WinFormsField XtractFilename = new WinFormsField("XTRACT-FILENAME", "XtractFilename");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
