using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBDSP10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBDSP10", "FormName");
		//Fields


        public static WinFormsField Jobnum = new WinFormsField("JOBNUM", "Jobnum");
        public static WinFormsField Jobid = new WinFormsField("JOBID", "Jobid");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Submitted = new WinFormsField("SUBMITTED", "Submitted");
        public static WinFormsField DefEoj = new WinFormsField("DEF-EOJ", "DefEoj");
        public static WinFormsField Etm = new WinFormsField("ETM", "Etm");
        public static WinFormsField JobNumber = new WinFormsField("JOB-NUMBER", "JobNumber");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
