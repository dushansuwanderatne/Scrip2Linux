using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELEPS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELEPS01", "FormName");
		//Fields


        public static WinFormsField LN = new WinFormsField("LN", "LN");
        public static WinFormsField File = new WinFormsField("FILE", "File");
        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
    }
}
