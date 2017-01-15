using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN60

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN60", "FormName");
		//Fields


        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField Title = new WinFormsField("TITLE", "Title");
        public static WinFormsField Line30Literal = new WinFormsField("LINE30-LITERAL", "Line30Literal");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
