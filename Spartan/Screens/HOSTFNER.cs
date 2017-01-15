using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFNER

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFNER", "FormName");
		//Fields


        public static WinFormsField MessageLine1 = new WinFormsField("MESSAGE-LINE1", "MessageLine1");
        public static WinFormsField MessageLine2 = new WinFormsField("MESSAGE-LINE2", "MessageLine2");
        public static WinFormsField MessageLine3 = new WinFormsField("MESSAGE-LINE3", "MessageLine3");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
