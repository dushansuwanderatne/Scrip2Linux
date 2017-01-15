using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS96499

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS96499", "FormName");
		//Fields


        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        //public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField SelectionCode = new WinFormsField("SELECTION-CODE", "SelectionCode");
    }
}
