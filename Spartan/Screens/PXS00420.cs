using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00420

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00420", "FormName");
		//Fields


        public static WinFormsField StageLastRun = new WinFormsField("STAGE-LAST-RUN", "StageLastRun");
        public static WinFormsField BriefDesc = new WinFormsField("BRIEF-DESC", "BriefDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
