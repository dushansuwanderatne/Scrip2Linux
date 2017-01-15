using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP01102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP01102", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField BspArrow = new WinFormsField("BSP-ARROW", "BspArrow");
        public static WinFormsField BspDesc = new WinFormsField("BSP-DESC", "BspDesc");
        public static WinFormsField DrpArrow = new WinFormsField("DRP-ARROW", "DrpArrow");
        public static WinFormsField DrpDesc = new WinFormsField("DRP-DESC", "DrpDesc");
    }
}
