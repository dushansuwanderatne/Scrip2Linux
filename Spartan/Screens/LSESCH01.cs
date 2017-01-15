using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LSESCH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LSESCH01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DisplayIsin = new WinFormsField("DISPLAY-ISIN", "DisplayIsin");
        public static WinFormsField Dot = new WinFormsField("DOT", "Dot");
        public static WinFormsField NameKey = new WinFormsField("NAME-KEY", "NameKey");
        public static WinFormsField Security = new WinFormsField("SECURITY", "Security");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchType = new WinFormsField("SEARCH-TYPE", "SearchType");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
