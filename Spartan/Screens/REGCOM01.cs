using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class REGCOM01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("REGCOM01", "FormName");
		//Fields


        public static WinFormsField RegcomKey0 = new WinFormsField("REGCOM-KEY0", "RegcomKey0");
        public static WinFormsField ShortDesc = new WinFormsField("SHORT-DESC", "ShortDesc");
        public static WinFormsField Post = new WinFormsField("POST", "Post");
        public static WinFormsField PostPhone = new WinFormsField("POST-PHONE", "PostPhone");
        public static WinFormsField Email = new WinFormsField("EMAIL", "Email");
        public static WinFormsField EmailPhone = new WinFormsField("EMAIL-PHONE", "EmailPhone");
        public static WinFormsField PostEmail = new WinFormsField("POST-EMAIL", "PostEmail");
        public static WinFormsField None = new WinFormsField("NONE", "None");
        public static WinFormsField Phone = new WinFormsField("PHONE", "Phone");
        public static WinFormsField All = new WinFormsField("ALL", "All");
        public static WinFormsField ScripPublication = new WinFormsField("SCRIP-PUBLICATION", "ScripPublication");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
