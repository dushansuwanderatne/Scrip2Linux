using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CAL01050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CAL01050", "FormName");
		//Fields


        public static WinFormsField NbrHolders = new WinFormsField("NBR-HOLDERS", "NbrHolders");
        public static WinFormsField MoneyPaid = new WinFormsField("MONEY-PAID", "MoneyPaid");
        public static WinFormsField UnitsPaid1Desc = new WinFormsField("UNITS-PAID1-DESC", "UnitsPaid1Desc");
        public static WinFormsField UnitsPaid1 = new WinFormsField("UNITS-PAID1", "UnitsPaid1");
        public static WinFormsField UnitsPaid2Desc = new WinFormsField("UNITS-PAID2-DESC", "UnitsPaid2Desc");
        public static WinFormsField UnitsPaid2 = new WinFormsField("UNITS-PAID2", "UnitsPaid2");
        public static WinFormsField OtherAllotedUnits = new WinFormsField("OTHER-ALLOTED-UNITS", "OtherAllotedUnits");
        public static WinFormsField DummyFld = new WinFormsField("DUMMY-FLD", "DummyFld");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
