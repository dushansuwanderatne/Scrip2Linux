using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLRUPD04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLRUPD04", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField Prefix = new WinFormsField("PREFIX", "Prefix");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField CpiIncrease = new WinFormsField("CPI-INCREASE", "CpiIncrease");
        public static WinFormsField PaperRate = new WinFormsField("PAPER-RATE", "PaperRate");
        public static WinFormsField Gen = new WinFormsField("GEN", "Gen");
    }
}
