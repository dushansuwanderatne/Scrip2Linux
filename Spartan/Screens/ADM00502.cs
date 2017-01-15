using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00502", "FormName");
		//Fields


        public static WinFormsField GroupSelected = new WinFormsField("GROUP-SELECTED", "GroupSelected");
        public static WinFormsField PnameCol1 = new WinFormsField("PNAME-COL1", "PnameCol1");
        public static WinFormsField PnameCol2 = new WinFormsField("PNAME-COL2", "PnameCol2");
    }
}
