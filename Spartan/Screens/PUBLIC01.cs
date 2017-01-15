using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PUBLIC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PUBLIC01", "FormName");
		//Fields


        public static WinFormsField MenuItemPE = new WinFormsField("MENU-ITEM-PE", "PE. Public Enquiry", "PublicEnquiry");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Public Enquiry", "ExitPublicEnquiry");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", "09", "09");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", "03", "03");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
