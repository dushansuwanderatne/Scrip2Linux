using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00111

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00111", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MeetingNumberFrom = new WinFormsField("MEETING-NUMBER-FROM", "MeetingNumberFrom");
    }
}
