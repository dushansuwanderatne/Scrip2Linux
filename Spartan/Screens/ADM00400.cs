using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00400

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00400", "FormName");
		//Fields


        public static WinFormsField PnameCol1 = new WinFormsField("PNAME-COL1", "PnameCol1");
        public static WinFormsField PnameCol2 = new WinFormsField("PNAME-COL2", "PnameCol2");
        public static WinFormsField ProjectSelected = new WinFormsField("PROJECT-SELECTED", "ProjectSelected");
    }
}
