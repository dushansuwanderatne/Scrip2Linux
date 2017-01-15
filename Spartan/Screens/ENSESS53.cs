using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS53

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS53", "FormName");
		//Fields
        public static WinFormsField ComplexHolderCode = new WinFormsField("COMPLEX-HOLDER-CODE", "ComplexHolderCode");
        public static WinFormsField ComplexHolderDesc = new WinFormsField("COMPLEX-HOLDER-DESC", "ComplexHolderDesc");
    }
}
