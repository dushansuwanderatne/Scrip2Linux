using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS19090

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS19090", "FormName");
		//Fields


        public static WinFormsField LogfileFrom = new WinFormsField("LOGFILE-FROM", "LogfileFrom");
        public static WinFormsField LogfileTO = new WinFormsField("LOGFILE-TO", "LogfileTO");
        public static WinFormsField TrajnlWritten = new WinFormsField("TRAJNL-WRITTEN", "TrajnlWritten");
        public static WinFormsField PrintName = new WinFormsField("PRINT-NAME", "PrintName");
        public static WinFormsField RunImmediately = new WinFormsField("RUN-IMMEDIATELY", "RunImmediately");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
