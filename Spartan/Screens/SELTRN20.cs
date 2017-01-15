using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELTRN20

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELTRN20", "FormName");
		//Fields
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField ListX = new WinFormsField("LIST-X", "ListX");
        public static WinFormsField Group = new WinFormsField("GROUP", "Group");
        public static WinFormsField Parent = new WinFormsField("PARENT", "Parent");
        public static WinFormsField SelCode = new WinFormsField("SEL-CODE", "SelCode");
        public static WinFormsField SelDescCode = new WinFormsField("SEL-DESC-CODE", "SelDescCode");
        public static WinFormsField SelParentCode = new WinFormsField("SEL-PARENT-CODE", "SelParentCode");
    }
}
