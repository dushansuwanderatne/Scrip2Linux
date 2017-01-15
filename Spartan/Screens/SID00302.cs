using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SID00302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SID00302", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TotalEntries = new WinFormsField("TOTAL-ENTRIES", "TotalEntries");
        public static WinFormsField Number = new WinFormsField("NUMBER", "Number");
        public static WinFormsField Dot = new WinFormsField("DOT", "Dot");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Record = new WinFormsField("RECORD", "Record");
        public static WinFormsField Owner = new WinFormsField("OWNER", "Owner");
        public static WinFormsField Topic1 = new WinFormsField("TOPIC1", "Topic1");
        public static WinFormsField Topic2 = new WinFormsField("TOPIC2", "Topic2");
        public static WinFormsField Topic3 = new WinFormsField("TOPIC3", "Topic3");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
