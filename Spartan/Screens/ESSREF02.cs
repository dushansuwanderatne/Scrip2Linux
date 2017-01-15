using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSREF02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSREF02", "FormName");
		//Fields


        public static WinFormsField FileType = new WinFormsField("FILE-TYPE", "FileType");
        public static WinFormsField BeforeImageGrp1 = new WinFormsField("BEFORE-IMAGE-GRP1", "BeforeImageGrp1");
        public static WinFormsField AfterImageGrp1 = new WinFormsField("AFTER-IMAGE-GRP1", "AfterImageGrp1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
