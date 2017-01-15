using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1048

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1048", "FormName");
		//Fields


        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField StartRef = new WinFormsField("START-REF", "StartRef");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
