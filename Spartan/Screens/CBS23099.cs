using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS23099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS23099", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField RowsExtracted = new WinFormsField("ROWS-EXTRACTED", "RowsExtracted");
    }
}
