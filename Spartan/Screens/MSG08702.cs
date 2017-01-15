using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG08702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG08702", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField EventRec = new WinFormsField("EVENT-REC", "EventRec");
    }
}
