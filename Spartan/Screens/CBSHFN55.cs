using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBSHFN55

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBSHFN55", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Ufd = new WinFormsField("UFD", "Ufd");
        public static WinFormsField F15 = new WinFormsField("F15", "F15");
        //public static WinFormsField F15 = new WinFormsField("F15", "F15");
        public static WinFormsField S15 = new WinFormsField("S15", "S15");
        //public static WinFormsField S15 = new WinFormsField("S15", "S15");
        public static WinFormsField Selected = new WinFormsField("SELECTED", "Selected");
    }
}
