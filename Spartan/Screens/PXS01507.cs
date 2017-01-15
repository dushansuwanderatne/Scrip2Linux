using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS01507

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS01507", "FormName");
		//Fields
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField AttendeeName = new WinFormsField("ATTENDEE-NAME", "AttendeeName");
        public static WinFormsField AtdType = new WinFormsField("ATD-TYPE", "AtdType");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
