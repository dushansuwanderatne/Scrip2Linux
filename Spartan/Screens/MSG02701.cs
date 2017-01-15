using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02701", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField GroupName = new WinFormsField("GROUP-NAME", "GroupName");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Alias = new WinFormsField("ALIAS", "Alias");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
