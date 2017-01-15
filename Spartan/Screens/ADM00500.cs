using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00500", "FormName");
		//Fields


        public static WinFormsField GnameCol1 = new WinFormsField("GNAME-COL1", "GnameCol1");
        public static WinFormsField GnameCol2 = new WinFormsField("GNAME-COL2", "GnameCol2");
        public static WinFormsField GroupSelected = new WinFormsField("GROUP-SELECTED", "GroupSelected");
        public static WinFormsField ListAction = new WinFormsField("LIST-ACTION", "ListAction");
    }
}
