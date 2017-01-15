using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STS006ND

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STS006ND", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ClientSelectionInd = new WinFormsField("CLIENT-SELECTION-IND", "ClientSelectionInd");
        public static WinFormsField ClientGroupCode = new WinFormsField("CLIENT-GROUP-CODE", "ClientGroupCode");
        public static WinFormsField VarianceInd = new WinFormsField("VARIANCE-IND", "VarianceInd");
        public static WinFormsField Variance = new WinFormsField("VARIANCE", "Variance");
    }
}
