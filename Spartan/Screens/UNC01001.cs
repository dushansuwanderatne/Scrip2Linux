using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UNC01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UNC01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PreloadDeleteInd = new WinFormsField("PRELOAD-DELETE-IND", "PreloadDeleteInd");
    }
}
