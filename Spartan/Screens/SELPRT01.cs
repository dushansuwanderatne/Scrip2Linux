using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELPRT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELPRT01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CurrentUfd = new WinFormsField("CURRENT-UFD", "CurrentUfd");
        public static WinFormsField LNF15 = new WinFormsField("LN-F15", "LNF15");
        public static WinFormsField FileF15 = new WinFormsField("FILE-F15", "FileF15");
        public static WinFormsField LNS15 = new WinFormsField("LN-S15", "LNS15");
        public static WinFormsField FileS15 = new WinFormsField("FILE-S15", "FileS15");
        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
    }
}
