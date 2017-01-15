using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00010", "FormName");
		//Fields


        public static WinFormsField TipsterName = new WinFormsField("TIPSTER-NAME", "TipsterName");
        public static WinFormsField TipsterPassword = new WinFormsField("TIPSTER-PASSWORD", "TipsterPassword");
        public static WinFormsField TipsterOrigin = new WinFormsField("TIPSTER-ORIGIN", "TipsterOrigin");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
