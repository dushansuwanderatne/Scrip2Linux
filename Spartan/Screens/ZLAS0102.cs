using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ZLAS0102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ZLAS0102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField IndexCode = new WinFormsField("INDEX-CODE", "IndexCode");
        public static WinFormsField IndexDesc = new WinFormsField("INDEX-DESC", "IndexDesc");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
