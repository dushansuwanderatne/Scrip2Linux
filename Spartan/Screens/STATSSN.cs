using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STATSSN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STATSSN", "FormName");
		//Fields


        public static WinFormsField MenuItemCtr = new WinFormsField("MENU-ITEM-CTR", "CTR.   Client Total Reporting", "ClientTotalReporting");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.    Exit System", "ExitSystem");
    }
}
