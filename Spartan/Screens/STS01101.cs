using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STS01101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STS01101", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField ClientHomeNode = new WinFormsField("CLIENT-HOME-NODE", "ClientHomeNode");
        public static WinFormsField Inter = new WinFormsField("INTER", "Inter");
        public static WinFormsField PrtLine = new WinFormsField("PRT-LINE", "PrtLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
