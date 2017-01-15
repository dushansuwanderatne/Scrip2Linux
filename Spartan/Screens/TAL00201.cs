using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAL00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAL00201", "FormName");
		//Fields


        public static WinFormsField ProblemNumber = new WinFormsField("PROBLEM-NUMBER", "ProblemNumber");
        public static WinFormsField ProblemDate = new WinFormsField("PROBLEM-DATE", "ProblemDate");
        public static WinFormsField BriefDesc = new WinFormsField("BRIEF-DESC", "BriefDesc");
        public static WinFormsField SelectedProblem = new WinFormsField("SELECTED-PROBLEM", "SelectedProblem");
    }
}
