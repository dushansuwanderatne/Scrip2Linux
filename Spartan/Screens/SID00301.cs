using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SID00301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SID00301", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Version = new WinFormsField("VERSION", "Version");
        public static WinFormsField SearchType = new WinFormsField("SEARCH-TYPE", "SearchType");
        public static WinFormsField SearchTypeFull = new WinFormsField("SEARCH-TYPE-FULL", "SearchTypeFull");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField DateAddedF = new WinFormsField("DATE-ADDED-F", "DateAddedF");
        public static WinFormsField DateAddedT = new WinFormsField("DATE-ADDED-T", "DateAddedT");
        public static WinFormsField DateReleasedF = new WinFormsField("DATE-RELEASED-F", "DateReleasedF");
        public static WinFormsField DateReleasedT = new WinFormsField("DATE-RELEASED-T", "DateReleasedT");
    }
}
