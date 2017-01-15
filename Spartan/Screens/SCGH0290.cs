using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCGH0290

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCGH0290", "FormName");
		//Fields


        public static WinFormsField LastChq = new WinFormsField("LAST-CHQ", "LastChq");
        public static WinFormsField LastHid = new WinFormsField("LAST-HID", "LastHid");
        public static WinFormsField NextChq = new WinFormsField("NEXT-CHQ", "NextChq");
        public static WinFormsField NextHid = new WinFormsField("NEXT-HID", "NextHid");
        public static WinFormsField ErrorDesc = new WinFormsField("ERROR-DESC", "ErrorDesc");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
