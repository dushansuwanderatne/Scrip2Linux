using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TALMAIN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TALMAIN", "FormName");
		//Fields


        public static WinFormsField MenuItemAdd = new WinFormsField("MENU-ITEM-ADD", "ADD.  Enter New Problem", "EnterNewProblem");
        public static WinFormsField MenuItemSel = new WinFormsField("MENU-ITEM-SEL", "SEL.  Select from Existing Problem", "SelectfromExistingProblem");
        public static WinFormsField MenuItemAsn = new WinFormsField("MENU-ITEM-ASN", "ASN.  Assign Problem", "AssignProblem");
        public static WinFormsField MenuItemCls = new WinFormsField("MENU-ITEM-CLS", "CLS.  Close Problem", "CloseProblem");
        public static WinFormsField MenuItemExt = new WinFormsField("MENU-ITEM-EXT", "EXT.  Exit From System", "ExitFromSystem");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
