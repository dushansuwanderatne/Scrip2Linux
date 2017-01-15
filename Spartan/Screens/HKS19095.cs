using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS19095

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS19095", "FormName");
		//Fields


        public static WinFormsField LogfileFrom = new WinFormsField("LOGFILE-FROM", "LogfileFrom");
        public static WinFormsField LogfileTO = new WinFormsField("LOGFILE-TO", "LogfileTO");
        public static WinFormsField TrajnlWritten = new WinFormsField("TRAJNL-WRITTEN", "TrajnlWritten");
    }
}
