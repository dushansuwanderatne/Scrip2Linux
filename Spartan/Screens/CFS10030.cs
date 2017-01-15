using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10030", "FormName");
		//Fields


        public static WinFormsField Header = new WinFormsField("HEADER", "Header");
        public static WinFormsField Coy1 = new WinFormsField("COY1", "Coy1");
        public static WinFormsField Name1 = new WinFormsField("NAME1", "Name1");
        public static WinFormsField Client1 = new WinFormsField("CLIENT1", "Client1");
        public static WinFormsField Coy2 = new WinFormsField("COY2", "Coy2");
        public static WinFormsField Name2 = new WinFormsField("NAME2", "Name2");
        public static WinFormsField Client2 = new WinFormsField("CLIENT2", "Client2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
