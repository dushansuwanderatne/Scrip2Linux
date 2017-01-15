using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP21

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP21", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Nsw = new WinFormsField("NSW", "Nsw");
        public static WinFormsField Vic = new WinFormsField("VIC", "Vic");
        public static WinFormsField Qld = new WinFormsField("QLD", "Qld");
        public static WinFormsField WA = new WinFormsField("WA", "WA");
        public static WinFormsField SA = new WinFormsField("SA", "SA");
        public static WinFormsField Tas = new WinFormsField("TAS", "Tas");
    }
}
