using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOTEMENU

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOTEMENU", "FormName");
		//Fields


        public static WinFormsField MenuItemNU = new WinFormsField("MENU-ITEM-NU", "NU. Notings Update / Enquiry", "NotingsUpdate/Enquiry");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit System", "ExitSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
