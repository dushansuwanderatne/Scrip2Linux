using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SAMP0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SAMP0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField RepDesc = new WinFormsField("REP-DESC", "RepDesc");
        public static WinFormsField RepType = new WinFormsField("REP-TYPE", "RepType");
        public static WinFormsField Termination = new WinFormsField("TERMINATION", "Termination");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField StartDateBegin = new WinFormsField("START-DATE-BEGIN", "StartDateBegin");
        public static WinFormsField StartDateEnd = new WinFormsField("START-DATE-END", "StartDateEnd");
        public static WinFormsField BusinessUnit1 = new WinFormsField("BUSINESS-UNIT1", "BusinessUnit1");
        public static WinFormsField JobBand1 = new WinFormsField("JOB-BAND1", "JobBand1");
        public static WinFormsField PayrollSystem1 = new WinFormsField("PAYROLL-SYSTEM1", "PayrollSystem1");
        public static WinFormsField PayrollSystem2 = new WinFormsField("PAYROLL-SYSTEM2", "PayrollSystem2");
        public static WinFormsField PayrollSystem3 = new WinFormsField("PAYROLL-SYSTEM3", "PayrollSystem3");
        public static WinFormsField XtractFilename = new WinFormsField("XTRACT-FILENAME", "XtractFilename");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
