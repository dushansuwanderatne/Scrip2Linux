using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ReturnCode = new WinFormsField("RETURN-CODE", "ReturnCode");
        public static WinFormsField ReturnMessage = new WinFormsField("RETURN-MESSAGE", "ReturnMessage");
        public static WinFormsField UfdName = new WinFormsField("UFD-NAME", "UfdName");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
    }
}
