using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01502", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField BspArrow = new WinFormsField("BSP-ARROW", "BspArrow");
        public static WinFormsField BspDesc = new WinFormsField("BSP-DESC", "BspDesc");
        public static WinFormsField DrpArrow = new WinFormsField("DRP-ARROW", "DrpArrow");
        public static WinFormsField DrpDesc = new WinFormsField("DRP-DESC", "DrpDesc");
    }
}
