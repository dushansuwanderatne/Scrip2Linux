using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01025", "FormName");
		//Fields


        public static WinFormsField LabelComment1 = new WinFormsField("LABEL-COMMENT-1", "LabelComment1");
        public static WinFormsField LabelComment2 = new WinFormsField("LABEL-COMMENT-2", "LabelComment2");
        public static WinFormsField LabelComment3 = new WinFormsField("LABEL-COMMENT-3", "LabelComment3");
        public static WinFormsField LabelComment4 = new WinFormsField("LABEL-COMMENT-4", "LabelComment4");
    }
}
