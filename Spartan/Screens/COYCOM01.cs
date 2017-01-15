using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COYCOM01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COYCOM01", "FormName");
		//Fields


        public static WinFormsField CoycomKey0 = new WinFormsField("COYCOM-KEY0", "CoycomKey0");
        public static WinFormsField EmllstNumber = new WinFormsField("EMLLST-NUMBER", "EmllstNumber");
        public static WinFormsField ManagerName = new WinFormsField("MANAGER-NAME", "ManagerName");
        public static WinFormsField AutoNotify = new WinFormsField("AUTO-NOTIFY", "AutoNotify");
        public static WinFormsField ManagerPhone = new WinFormsField("MANAGER-PHONE", "ManagerPhone");
        public static WinFormsField AutoUpdate = new WinFormsField("AUTO-UPDATE", "AutoUpdate");
        public static WinFormsField EmailFirst78 = new WinFormsField("EMAIL-FIRST-78", "EmailFirst78");
        public static WinFormsField Post = new WinFormsField("POST", "Post");
        public static WinFormsField PostPhone = new WinFormsField("POST-PHONE", "PostPhone");
        public static WinFormsField Email = new WinFormsField("EMAIL", "Email");
        public static WinFormsField EmailPhone = new WinFormsField("EMAIL-PHONE", "EmailPhone");
        public static WinFormsField PostEmail = new WinFormsField("POST-EMAIL", "PostEmail");
        public static WinFormsField None = new WinFormsField("NONE", "None");
        public static WinFormsField Phone = new WinFormsField("PHONE", "Phone");
        public static WinFormsField All = new WinFormsField("ALL", "All");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
