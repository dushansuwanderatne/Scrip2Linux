using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRESTERR

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRESTERR", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ErrorCode = new WinFormsField("ERROR-CODE", "ErrorCode");
        public static WinFormsField ErrorDesc = new WinFormsField("ERROR-DESC", "ErrorDesc");
    }
}