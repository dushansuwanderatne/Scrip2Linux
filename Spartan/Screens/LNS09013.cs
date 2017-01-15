using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS09013

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS09013", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField LinkDescription = new WinFormsField("LINK-DESCRIPTION", "LinkDescription");
        public static WinFormsField GlobalChangeFlag = new WinFormsField("GLOBAL-CHANGE-FLAG", "GlobalChangeFlag");
        public static WinFormsField CategoryChanges1 = new WinFormsField("CATEGORY-CHANGES-1", "CategoryChanges1");
        public static WinFormsField CategoryChanges2 = new WinFormsField("CATEGORY-CHANGES-2", "CategoryChanges2");
    }
}
