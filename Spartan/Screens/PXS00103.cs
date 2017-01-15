using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00103", "FormName");
		//Fields
        public static WinFormsField PasswordOutput = new WinFormsField("PASSWORD-OUTPUT", "PasswordOutput");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField PasswordInput = new WinFormsField("PASSWORD-INPUT", "PasswordInput");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField TextLine = new WinFormsField("TEXT-LINE", "TextLine");
    }
}
