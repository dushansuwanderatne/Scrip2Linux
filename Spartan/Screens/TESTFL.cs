using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TESTFL

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TESTFL", "FormName");
		//Fields


        public static WinFormsField MenuItemScf = new WinFormsField("MENU-ITEM-SCF", "SCF.  Scrip Formats", "ScripFormats");
        public static WinFormsField MenuItemNsf = new WinFormsField("MENU-ITEM-NSF", "NSF.  Newshareholder Formats", "NewshareholderFormats");
        public static WinFormsField MenuItemDvf = new WinFormsField("MENU-ITEM-DVF", "DVF.  Dividend Formats", "DividendFormats");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit System", "ExitSystem");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 2", "2");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
