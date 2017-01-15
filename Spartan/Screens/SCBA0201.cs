using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCBA0201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCBA0201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField BoxNumber = new WinFormsField("BOX-NUMBER", "BoxNumber");
        public static WinFormsField StartTrans = new WinFormsField("START-TRANS", "StartTrans");
        public static WinFormsField EndTrans = new WinFormsField("END-TRANS", "EndTrans");
        public static WinFormsField MissingTrans1 = new WinFormsField("MISSING-TRANS-1", "MissingTrans1");
        public static WinFormsField MissingTrans2 = new WinFormsField("MISSING-TRANS-2", "MissingTrans2");
        public static WinFormsField NumberUnits1 = new WinFormsField("NUMBER-UNITS-1", "NumberUnits1");
        public static WinFormsField NumberUnits2 = new WinFormsField("NUMBER-UNITS-2", "NumberUnits2");
        public static WinFormsField NumberUnits3 = new WinFormsField("NUMBER-UNITS-3", "NumberUnits3");
        public static WinFormsField DiffShares = new WinFormsField("DIFF-SHARES", "DiffShares");
        public static WinFormsField AmountMoney1 = new WinFormsField("AMOUNT-MONEY-1", "AmountMoney1");
        public static WinFormsField AmountMoney2 = new WinFormsField("AMOUNT-MONEY-2", "AmountMoney2");
        public static WinFormsField AmountMoney3 = new WinFormsField("AMOUNT-MONEY-3", "AmountMoney3");
        public static WinFormsField DiffMoney = new WinFormsField("DIFF-MONEY", "DiffMoney");
        public static WinFormsField AmountMoney4 = new WinFormsField("AMOUNT-MONEY-4", "AmountMoney4");
        public static WinFormsField Initials = new WinFormsField("INITIALS", "Initials");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
