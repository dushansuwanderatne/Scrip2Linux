using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELRUN03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELRUN03", "FormName");
		//Fields


        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
        public static WinFormsField FieldData = new WinFormsField("FIELD-DATA", "FieldData");
        public static WinFormsField FieldDesc = new WinFormsField("FIELD-DESC", "FieldDesc");
    }
}
