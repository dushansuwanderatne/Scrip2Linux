using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PIKFIL10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PIKFIL10", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField Nbr = new WinFormsField("NBR", "Nbr");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
        public static WinFormsField Header = new WinFormsField("HEADER", "Header");
        public static WinFormsField Oflow = new WinFormsField("OFLOW", "Oflow");
    }
}
