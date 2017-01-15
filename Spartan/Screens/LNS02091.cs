using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS02091

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS02091", "FormName");
		//Fields


        public static WinFormsField Hid = new WinFormsField("HID", "Hid");
        public static WinFormsField TranDesc = new WinFormsField("TRAN-DESC", "TranDesc");
        public static WinFormsField TranDate = new WinFormsField("TRAN-DATE", "TranDate");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
