using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS17011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS17011", "FormName");
		//Fields


        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Apply DPID without address corrections", "ApplyDPIDwithoutaddresscorrections");
        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C. Apply DPID and address corrections", "ApplyDPIDandaddresscorrections");
        public static WinFormsField MenuItemR = new WinFormsField("MENU-ITEM-R", "R. Report Mode Only (no updates)", "ReportModeOnly(noupdates)");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
