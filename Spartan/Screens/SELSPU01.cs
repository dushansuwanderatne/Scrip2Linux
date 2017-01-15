using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELSPU01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELSPU01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CurrentUfd = new WinFormsField("CURRENT-UFD", "CurrentUfd");
        public static WinFormsField LNF15 = new WinFormsField("LN-F15", "LNF15");
        public static WinFormsField UfdF15 = new WinFormsField("UFD-F15", "UfdF15");
        public static WinFormsField LNS15 = new WinFormsField("LN-S15", "LNS15");
        public static WinFormsField UfdS15 = new WinFormsField("UFD-S15", "UfdS15");
        public static WinFormsField UfdSelected = new WinFormsField("UFD-SELECTED", "UfdSelected");
        public static WinFormsField DivUfd = new WinFormsField("DIV-UFD", "DivUfd");
    }
}
