using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STS006SN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STS006SN", "FormName");
		//Fields


        public static WinFormsField ClientSelectionInd = new WinFormsField("CLIENT-SELECTION-IND", "ClientSelectionInd");
        public static WinFormsField ClientGroupCode = new WinFormsField("CLIENT-GROUP-CODE", "ClientGroupCode");
        public static WinFormsField VarianceInd = new WinFormsField("VARIANCE-IND", "VarianceInd");
        public static WinFormsField Variance = new WinFormsField("VARIANCE", "Variance");
    }
}
