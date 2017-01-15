using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SID00123

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SID00123", "FormName");
		//Fields


        public static WinFormsField Entries120 = new WinFormsField("ENTRIES-1-20", "Entries120");
        public static WinFormsField Entries2140 = new WinFormsField("ENTRIES-21-40", "Entries2140");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Key = new WinFormsField("KEY", "Key");
    }
}
