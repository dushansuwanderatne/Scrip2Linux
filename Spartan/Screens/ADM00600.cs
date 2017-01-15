using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00600

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00600", "FormName");
		//Fields


        public static WinFormsField MenuItemCksd = new WinFormsField("MENU-ITEM-CKSD", "CKSD.   Check The Condition Of The SAD", "CheckTheConditionOfTheSAD");
        public static WinFormsField MenuItemRbld = new WinFormsField("MENU-ITEM-RBLD", "RBLD.   Rebuild The SAD", "RebuildTheSAD");
        public static WinFormsField MenuItemWipe = new WinFormsField("MENU-ITEM-WIPE", "WIPE.   Wipe A User Off The System", "WipeAUserOffTheSystem");
        public static WinFormsField MenuItemVrfy = new WinFormsField("MENU-ITEM-VRFY", "VRFY.   Verify User At Other Nodes", "VerifyUserAtOtherNodes");
        public static WinFormsField MenuItemSecr = new WinFormsField("MENU-ITEM-SECR", "SECR.   System Security Options", "SystemSecurityOptions");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
