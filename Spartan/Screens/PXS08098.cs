using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS08098

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS08098", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RefNum = new WinFormsField("REF-NUM", "RefNum");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
