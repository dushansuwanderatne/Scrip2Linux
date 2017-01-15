using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01106

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01106", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        //public static WinFormsField 260 = new WinFormsField("2-60", "260");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
