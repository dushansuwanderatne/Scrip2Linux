using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN66

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN66", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Init = new WinFormsField("INIT", "Init");
        public static WinFormsField Reason = new WinFormsField("REASON", "Reason");
    }
}
