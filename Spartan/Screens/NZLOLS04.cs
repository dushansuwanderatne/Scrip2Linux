using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLOLS04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLOLS04", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OriginalRunNumber = new WinFormsField("ORIGINAL-RUN-NUMBER", "OriginalRunNumber");
        public static WinFormsField OriginalTransNumber = new WinFormsField("ORIGINAL-TRANS-NUMBER", "OriginalTransNumber");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
