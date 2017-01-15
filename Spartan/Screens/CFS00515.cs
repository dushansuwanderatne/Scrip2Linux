using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00515

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00515", "FormName");
		//Fields


        public static WinFormsField MenuID = new WinFormsField("MENU-ID", "MenuID");
        public static WinFormsField TransType124 = new WinFormsField("TRANS-TYPE-1-24", "TransType124");
        public static WinFormsField TransDesc124 = new WinFormsField("TRANS-DESC-1-24", "TransDesc124");
        public static WinFormsField TransType2548 = new WinFormsField("TRANS-TYPE-25-48", "TransType2548");
        public static WinFormsField TransDesc2548 = new WinFormsField("TRANS-DESC-25-48", "TransDesc2548");
        public static WinFormsField TransType4972 = new WinFormsField("TRANS-TYPE-49-72", "TransType4972");
        public static WinFormsField TransDesc4972 = new WinFormsField("TRANS-DESC-49-72", "TransDesc4972");
    }
}
