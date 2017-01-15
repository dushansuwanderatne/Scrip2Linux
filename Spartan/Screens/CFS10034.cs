using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10034

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10034", "FormName");
		//Fields


        public static WinFormsField RspMode = new WinFormsField("RSP-MODE", "RspMode");
        public static WinFormsField RspFile = new WinFormsField("RSP-FILE", "RspFile");
    }
}
