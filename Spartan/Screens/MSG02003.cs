using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField NumberSent = new WinFormsField("NUMBER-SENT", "NumberSent");
        public static WinFormsField NumberRequested = new WinFormsField("NUMBER-REQUESTED", "NumberRequested");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
