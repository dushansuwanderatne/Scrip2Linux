using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO02020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO02020", "FormName");
		//Fields


        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField TkoCode = new WinFormsField("TKO-CODE", "TkoCode");
        public static WinFormsField TkoDesc = new WinFormsField("TKO-DESC", "TkoDesc");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
