using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS23499

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS23499", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField Read = new WinFormsField("READ", "Read");
        public static WinFormsField INError = new WinFormsField("IN-ERROR", "INError");
       // public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
    }
}
