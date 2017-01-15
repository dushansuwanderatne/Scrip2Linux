using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT0920

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT0920", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ApplicationID = new WinFormsField("APPLICATION-ID", "ApplicationID");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
