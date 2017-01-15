using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00603

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00603", "FormName");
		//Fields


        public static WinFormsField UnameCol1 = new WinFormsField("UNAME-COL1", "UnameCol1");
        public static WinFormsField UnameCol2 = new WinFormsField("UNAME-COL2", "UnameCol2");
        public static WinFormsField UserSelected = new WinFormsField("USER-SELECTED", "UserSelected");
    }
}