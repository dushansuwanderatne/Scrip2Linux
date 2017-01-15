using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS02098

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS02098", "FormName");
		//Fields


        public static WinFormsField RefNum = new WinFormsField("REF-NUM", "RefNum");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
