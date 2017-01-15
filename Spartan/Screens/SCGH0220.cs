using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCGH0220

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCGH0220", "FormName");
		//Fields


        public static WinFormsField RangeDetails = new WinFormsField("RANGE-DETAILS", "RangeDetails");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
