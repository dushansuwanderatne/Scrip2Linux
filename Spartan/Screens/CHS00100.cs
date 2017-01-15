using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS00100", "FormName");
		//Fields


        public static WinFormsField MenuItemTctc = new WinFormsField("MENU-ITEM-TCTC", "TCTC. Transfers and Conversions (to) CHESS", "TransfersandConversions(to)CHESS");
        public static WinFormsField MenuItemTcfc = new WinFormsField("MENU-ITEM-TCFC", "TCFC. Transfers and Conversions (from) CHESS", "TransfersandConversions(from)CHESS");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TempUic = new WinFormsField("TEMP-UIC", "TempUic");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
