using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELRUN02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELRUN02", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField Nbr = new WinFormsField("NBR", "Nbr");
        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
        public static WinFormsField Oflow = new WinFormsField("OFLOW", "Oflow");
    }
}
