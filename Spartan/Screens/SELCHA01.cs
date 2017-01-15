using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELCHA01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELCHA01", "FormName");
		//Fields
        public static WinFormsField CharityCode = new WinFormsField("CHARITY-CODE", "CharityCode");
        public static WinFormsField CharityDesc = new WinFormsField("CHARITY-DESC", "CharityDesc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
