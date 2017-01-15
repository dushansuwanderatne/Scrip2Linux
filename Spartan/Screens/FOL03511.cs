using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL03511

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL03511", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CompoundAmt = new WinFormsField("COMPOUND-AMT", "CompoundAmt");
        public static WinFormsField FidOwing = new WinFormsField("FID-OWING", "FidOwing");
        public static WinFormsField FidTORecover = new WinFormsField("FID-TO-RECOVER", "FidTORecover");
    }
}
