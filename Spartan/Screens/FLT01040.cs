using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLT01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLT01040", "FormName");
		//Fields


        public static WinFormsField AutospoolPrinter = new WinFormsField("AUTOSPOOL-PRINTER", "AutospoolPrinter");
        public static WinFormsField AutospoolFormType = new WinFormsField("AUTOSPOOL-FORM-TYPE", "AutospoolFormType");
        public static WinFormsField RangeUnitsTO1 = new WinFormsField("RANGE-UNITS-TO-1", "RangeUnitsTO1");
        public static WinFormsField RangeUnitsTO2 = new WinFormsField("RANGE-UNITS-TO-2", "RangeUnitsTO2");
        public static WinFormsField RangeUnitsTO3 = new WinFormsField("RANGE-UNITS-TO-3", "RangeUnitsTO3");
        public static WinFormsField RangeUnitsTO4 = new WinFormsField("RANGE-UNITS-TO-4", "RangeUnitsTO4");
        public static WinFormsField RangeUnitsTO5 = new WinFormsField("RANGE-UNITS-TO-5", "RangeUnitsTO5");
        public static WinFormsField RangeUnitsTO6 = new WinFormsField("RANGE-UNITS-TO-6", "RangeUnitsTO6");
        public static WinFormsField HvfExceptionNbr = new WinFormsField("HVF-EXCEPTION-NBR", "HvfExceptionNbr");
        public static WinFormsField ExcLegitimateValue = new WinFormsField("EXC-LEGITIMATE-VALUE", "ExcLegitimateValue");
        public static WinFormsField ExcProblemValue = new WinFormsField("EXC-PROBLEM-VALUE", "ExcProblemValue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
