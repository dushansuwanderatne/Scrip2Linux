using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00606

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00606", "FormName");
		//Fields


        public static WinFormsField MenuItemOver = new WinFormsField("MENU-ITEM-OVER", "OVER.   Users Overdue For A Password Change", "UsersOverdueForAPasswordChange");
        public static WinFormsField MenuItemInfn = new WinFormsField("MENU-ITEM-INFN", "INFN.   Users With An Infinite Password Lifetime", "UsersWithAnInfinitePasswordLifetime");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
