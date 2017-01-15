using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00117

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00117", "FormName");
		//Fields


        public static WinFormsField PrevCutoffPoint = new WinFormsField("PREV-CUTOFF-POINT", "PrevCutoffPoint");
        public static WinFormsField Pxs00117PrevClass = new WinFormsField("PXS00117-PREV-CLASS", "Pxs00117PrevClass");
        public static WinFormsField PrevClassGroup = new WinFormsField("PREV-CLASS-GROUP", "PrevClassGroup");
        public static WinFormsField PrevRatioClass = new WinFormsField("PREV-RATIO-CLASS", "PrevRatioClass");
        public static WinFormsField UsePreviousParams = new WinFormsField("USE-PREVIOUS-PARAMS", "UsePreviousParams");
        public static WinFormsField CutoffPoint = new WinFormsField("CUTOFF-POINT", "CutoffPoint");
        public static WinFormsField Pxs00117Class = new WinFormsField("PXS00117-CLASS", "Pxs00117Class");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField RatioClass = new WinFormsField("RATIO-CLASS", "RatioClass");
    }
}
