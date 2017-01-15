using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS60

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS60", "FormName");
		//Fields


        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
