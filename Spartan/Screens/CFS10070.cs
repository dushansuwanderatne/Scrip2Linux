using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10070

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10070", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Coy = new WinFormsField("COY", "Coy");
        public static WinFormsField Header = new WinFormsField("HEADER", "Header");
        public static WinFormsField Rsp = new WinFormsField("RSP", "Rsp");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
