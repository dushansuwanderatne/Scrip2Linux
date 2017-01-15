using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELVWP00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELVWP00", "FormName");
		//Fields
        public static WinFormsField InputClassCode = new WinFormsField("INPUT-CLASS-CODE", "InputClassCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField InputDate = new WinFormsField("INPUT-DATE", "InputDate");
    }
}
