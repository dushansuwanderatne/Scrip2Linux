using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOM01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOM01040", "FormName");
		//Fields


        public static WinFormsField EntryDate = new WinFormsField("ENTRY-DATE", "EntryDate");
        public static WinFormsField EntryMsgid = new WinFormsField("ENTRY-MSGID", "EntryMsgid");
        public static WinFormsField LCDate = new WinFormsField("LC-DATE", "LCDate");
        public static WinFormsField LCMsgid = new WinFormsField("LC-MSGID", "LCMsgid");
    }
}
