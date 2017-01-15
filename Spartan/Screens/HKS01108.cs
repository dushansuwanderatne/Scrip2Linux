using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01108

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01108", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AsxDesc = new WinFormsField("ASX-DESC", "AsxDesc");
        public static WinFormsField LseDesc = new WinFormsField("LSE-DESC", "LseDesc");
        public static WinFormsField DepositaryHin = new WinFormsField("DEPOSITARY-HIN", "DepositaryHin");
        public static WinFormsField DepositaryClass = new WinFormsField("DEPOSITARY-CLASS", "DepositaryClass");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
    }
}
