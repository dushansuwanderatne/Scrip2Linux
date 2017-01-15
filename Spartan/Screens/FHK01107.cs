using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01107

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01107", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
       // public static WinFormsField 340 = new WinFormsField("3-40", "340");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
