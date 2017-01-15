using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ONLTFR04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ONLTFR04", "FormName");
		//Fields


        public static WinFormsField TfrBCL = new WinFormsField("TFR-B-CL", "TfrBCL");
        public static WinFormsField TfrBR = new WinFormsField("TFR-B-R", "TfrBR");
        public static WinFormsField TfrBBroker = new WinFormsField("TFR-B-BROKER", "TfrBBroker");
        public static WinFormsField TfrBBname = new WinFormsField("TFR-B-BNAME", "TfrBBname");
        public static WinFormsField TfrBHN = new WinFormsField("TFR-B-HN", "TfrBHN");
        public static WinFormsField TfrBSplitNO = new WinFormsField("TFR-B-SPLIT-NO", "TfrBSplitNO");
        public static WinFormsField TfrBSplitDen = new WinFormsField("TFR-B-SPLIT-DEN", "TfrBSplitDen");
        public static WinFormsField TfrBNal = new WinFormsField("TFR-B-NAL", "TfrBNal");
        public static WinFormsField TfrBFil = new WinFormsField("TFR-B-FIL", "TfrBFil");
    }
}
