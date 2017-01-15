using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10011", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Iss = new WinFormsField("ISS", "Iss");
        public static WinFormsField IssueFrom = new WinFormsField("ISSUE-FROM", "IssueFrom");
        public static WinFormsField IssueTO = new WinFormsField("ISSUE-TO", "IssueTO");
        public static WinFormsField Exd = new WinFormsField("EXD", "Exd");
        public static WinFormsField MaturityFrom = new WinFormsField("MATURITY-FROM", "MaturityFrom");
        public static WinFormsField MaturityTO = new WinFormsField("MATURITY-TO", "MaturityTO");
        public static WinFormsField InterestFrom = new WinFormsField("INTEREST-FROM", "InterestFrom");
        public static WinFormsField InterestTO = new WinFormsField("INTEREST-TO", "InterestTO");
        public static WinFormsField BalanceFrom = new WinFormsField("BALANCE-FROM", "BalanceFrom");
        public static WinFormsField BalanceTO = new WinFormsField("BALANCE-TO", "BalanceTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
