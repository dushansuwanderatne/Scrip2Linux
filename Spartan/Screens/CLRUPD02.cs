using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLRUPD02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLRUPD02", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField Prefix = new WinFormsField("PREFIX", "Prefix");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField CpiIncrease = new WinFormsField("CPI-INCREASE", "CpiIncrease");
        public static WinFormsField Inter = new WinFormsField("INTER", "Inter");
        public static WinFormsField PrtLine = new WinFormsField("PRT-LINE", "PrtLine");
        public static WinFormsField HNMonth = new WinFormsField("HN-MONTH", "HNMonth");
        public static WinFormsField Online = new WinFormsField("ONLINE", "Online");
        public static WinFormsField TranRate = new WinFormsField("TRAN-RATE", "TranRate");
        public static WinFormsField Minimum = new WinFormsField("MINIMUM", "Minimum");
        public static WinFormsField HNCall = new WinFormsField("HN-CALL", "HNCall");
        public static WinFormsField HNBonus = new WinFormsField("HN-BONUS", "HNBonus");
        public static WinFormsField HNIssue = new WinFormsField("HN-ISSUE", "HNIssue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
