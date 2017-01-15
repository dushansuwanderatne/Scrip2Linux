using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01009

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01009", "FormName");
		//Fields
        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField Selreg = new WinFormsField("SELREG", "Selreg");
        public static WinFormsField RegType = new WinFormsField("REG-TYPE", "RegType");
        public static WinFormsField Participants = new WinFormsField("PARTICIPANTS", "Participants");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
