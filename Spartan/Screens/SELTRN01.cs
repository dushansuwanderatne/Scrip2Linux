using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELTRN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELTRN01", "FormName");
		//Fields


        public static WinFormsField SelCode = new WinFormsField("SEL-CODE", "SelCode");
        public static WinFormsField SelDescCode = new WinFormsField("SEL-DESC-CODE", "SelDescCode");
        public static WinFormsField SelParentCode = new WinFormsField("SEL-PARENT-CODE", "SelParentCode");
    }
}
