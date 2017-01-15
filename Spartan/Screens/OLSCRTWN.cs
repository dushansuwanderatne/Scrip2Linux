using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTWN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTWN", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CheckNumber = new WinFormsField("CHECK-NUMBER", "CheckNumber");
        public static WinFormsField AsxUfd = new WinFormsField("ASX-UFD", "AsxUfd");
        public static WinFormsField AsxClass = new WinFormsField("ASX-CLASS", "AsxClass");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField UnitsTraded = new WinFormsField("UNITS-TRADED", "UnitsTraded");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
