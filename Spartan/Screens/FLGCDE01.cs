using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLGCDE01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLGCDE01", "FormName");
		//Fields


        public static WinFormsField FlgcdeKey0 = new WinFormsField("FLGCDE-KEY0", "FlgcdeKey0");
        public static WinFormsField UserFlagType = new WinFormsField("USER-FLAG-TYPE", "UserFlagType");
        public static WinFormsField UserFlagNumber = new WinFormsField("USER-FLAG-NUMBER", "UserFlagNumber");
        public static WinFormsField UserFlagValue = new WinFormsField("USER-FLAG-VALUE", "UserFlagValue");
        public static WinFormsField UserFlagDesc = new WinFormsField("USER-FLAG-DESC", "UserFlagDesc");
        public static WinFormsField UserFlagMnemonic = new WinFormsField("USER-FLAG-MNEMONIC", "UserFlagMnemonic");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
