using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PIKFIL11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PIKFIL11", "FormName");
		//Fields


        public static WinFormsField FilenameL = new WinFormsField("FILENAME-L", "FilenameL");
        public static WinFormsField NbrL = new WinFormsField("NBR-L", "NbrL");
        public static WinFormsField FilenameR = new WinFormsField("FILENAME-R", "FilenameR");
        public static WinFormsField NbrR = new WinFormsField("NBR-R", "NbrR");
        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
        public static WinFormsField Oflow = new WinFormsField("OFLOW", "Oflow");
        public static WinFormsField Header = new WinFormsField("HEADER", "Header");
    }
}
