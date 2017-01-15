using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTRC

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTRC", "FormName");
		//Fields


        public static WinFormsField ReasonCode1 = new WinFormsField("REASON-CODE-1", "ReasonCode1");
        public static WinFormsField Description1 = new WinFormsField("DESCRIPTION-1", "Description1");
        public static WinFormsField ReasonCode2 = new WinFormsField("REASON-CODE-2", "ReasonCode2");
        public static WinFormsField Description2 = new WinFormsField("DESCRIPTION-2", "Description2");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
