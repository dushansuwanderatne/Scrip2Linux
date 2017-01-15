using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ROLDSC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ROLDSC01", "FormName");
		//Fields


        public static WinFormsField RollupType = new WinFormsField("ROLLUP-TYPE", "RollupType");
        public static WinFormsField SegmentNumber = new WinFormsField("SEGMENT-NUMBER", "SegmentNumber");
        public static WinFormsField GroupNumber = new WinFormsField("GROUP-NUMBER", "GroupNumber");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField RoldscKey0 = new WinFormsField("ROLDSC-KEY0", "RoldscKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField PurposeType = new WinFormsField("PURPOSE-TYPE", "PurposeType");
    }
}
