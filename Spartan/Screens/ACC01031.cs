using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01031

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01031", "FormName");
		//Fields


        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
