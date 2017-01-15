using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSGNRT0

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSGNRT0", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MsgFile = new WinFormsField("MSG-FILE", "MsgFile");
        public static WinFormsField Scrip = new WinFormsField("SCRIP", "Scrip");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
