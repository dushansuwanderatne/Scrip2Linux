using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STS00905

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STS00905", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField Prefix = new WinFormsField("PREFIX", "Prefix");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField CpiIncrease = new WinFormsField("CPI-INCREASE", "CpiIncrease");
        public static WinFormsField GstExempt = new WinFormsField("GST-EXEMPT", "GstExempt");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField AttentionOF = new WinFormsField("ATTENTION-OF", "AttentionOF");
        public static WinFormsField Gen = new WinFormsField("GEN", "Gen");
    }
}
