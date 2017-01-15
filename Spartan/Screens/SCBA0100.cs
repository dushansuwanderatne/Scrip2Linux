using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCBA0100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCBA0100", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField BoxNumber = new WinFormsField("BOX-NUMBER", "BoxNumber");
        public static WinFormsField StartTrans = new WinFormsField("START-TRANS", "StartTrans");
        public static WinFormsField EndTrans = new WinFormsField("END-TRANS", "EndTrans");
        public static WinFormsField NumberUnits1 = new WinFormsField("NUMBER-UNITS-1", "NumberUnits1");
        public static WinFormsField AmountMoney1 = new WinFormsField("AMOUNT-MONEY-1", "AmountMoney1");
        public static WinFormsField Initials = new WinFormsField("INITIALS", "Initials");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Add = new WinFormsField("ADD", "Add");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
