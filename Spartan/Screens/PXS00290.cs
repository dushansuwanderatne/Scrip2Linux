using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;


namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00290

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00290", "FormName");
		//Fields
        public static WinFormsField PrintFilename = new WinFormsField("PRINT-FILENAME", "PrintFilename");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField Comment = new WinFormsField("COMMENT", "Comment");
    }
}
