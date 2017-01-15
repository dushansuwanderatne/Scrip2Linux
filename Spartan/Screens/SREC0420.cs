using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SREC0420

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SREC0420", "FormName");
		//Fields


        public static WinFormsField RangeDetails = new WinFormsField("RANGE-DETAILS", "RangeDetails");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
