using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS15002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS15002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SelectionProcess = new WinFormsField("SELECTION-PROCESS", "SelectionProcess");
        public static WinFormsField AsxCode = new WinFormsField("ASX-CODE", "AsxCode");
        public static WinFormsField BalanceFrom = new WinFormsField("BALANCE-FROM", "BalanceFrom");
        public static WinFormsField BalanceTO = new WinFormsField("BALANCE-TO", "BalanceTO");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
        public static WinFormsField RepSeq = new WinFormsField("REP-SEQ", "RepSeq");
        public static WinFormsField AsxForBal = new WinFormsField("ASX-FOR-BAL", "AsxForBal");
        public static WinFormsField CutoffLevel = new WinFormsField("CUTOFF-LEVEL", "CutoffLevel");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
