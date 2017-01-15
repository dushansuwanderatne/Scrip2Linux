using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STS00904

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STS00904", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField Prefix = new WinFormsField("PREFIX", "Prefix");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField CpiIncrease = new WinFormsField("CPI-INCREASE", "CpiIncrease");
        public static WinFormsField PaperRate = new WinFormsField("PAPER-RATE", "PaperRate");
        public static WinFormsField Edc = new WinFormsField("EDC", "Edc");
        public static WinFormsField Workflow = new WinFormsField("WORKFLOW", "Workflow");
        public static WinFormsField Xml = new WinFormsField("XML", "Xml");
        public static WinFormsField Email = new WinFormsField("EMAIL", "Email");
        public static WinFormsField MaxReglstAllow = new WinFormsField("MAX-REGLST-ALLOW", "MaxReglstAllow");
        public static WinFormsField PrintChargesONInv = new WinFormsField("PRINT-CHARGES-ON-INV", "PrintChargesONInv");
    }
}
