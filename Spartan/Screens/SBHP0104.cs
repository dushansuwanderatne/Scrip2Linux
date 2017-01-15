using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP0104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP0104", "FormName");
		//Fields


        public static WinFormsField MenuItemBeoex = new WinFormsField("MENU-ITEM-BEOEX", "BEOEX.  Options Exercise", "OptionsExercise");
        public static WinFormsField MenuItemBeoer = new WinFormsField("MENU-ITEM-BEOER", "BEOER.  Options Exercise Reversal", "OptionsExerciseReversal");
        public static WinFormsField MenuItemBeotf = new WinFormsField("MENU-ITEM-BEOTF", "BEOTF.  Options Transfer", "OptionsTransfer");
        public static WinFormsField MenuItemBeolp = new WinFormsField("MENU-ITEM-BEOLP", "BEOLP.  Options Lapse", "OptionsLapse");
        public static WinFormsField MenuItemBeolr = new WinFormsField("MENU-ITEM-BEOLR", "BEOLR.  Options Lapse Reversal", "OptionsLapseReversal");
        public static WinFormsField MenuItemBeoed = new WinFormsField("MENU-ITEM-BEOED", "BEOED.  Alter Options Exercise Date", "AlterOptionsExerciseDate");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Session Totals", "SessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
