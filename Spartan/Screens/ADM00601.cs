using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00601", "FormName");
		//Fields


        public static WinFormsField ProjectTORebuild = new WinFormsField("PROJECT-TO-REBUILD", "ProjectTORebuild");
        public static WinFormsField ProjectedNumber = new WinFormsField("PROJECTED-NUMBER", "ProjectedNumber");
        public static WinFormsField ConfirmRebuild = new WinFormsField("CONFIRM-REBUILD", "ConfirmRebuild");
    }
}
