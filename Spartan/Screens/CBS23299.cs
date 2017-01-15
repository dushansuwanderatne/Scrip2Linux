using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS23299

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS23299", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField RowsImported = new WinFormsField("ROWS-IMPORTED", "RowsImported");
        public static WinFormsField RowsINError = new WinFormsField("ROWS-IN-ERROR", "RowsINError");
        //public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
    }
}
