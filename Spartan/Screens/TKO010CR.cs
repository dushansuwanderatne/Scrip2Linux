using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO010CR

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO010CR", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AgentID = new WinFormsField("AGENT-ID", "AgentID");
        public static WinFormsField AccountID = new WinFormsField("ACCOUNT-ID", "AccountID");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
