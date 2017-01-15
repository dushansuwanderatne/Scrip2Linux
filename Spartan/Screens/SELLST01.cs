using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELLST01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELLST01", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField ScreenHeading = new WinFormsField("SCREEN-HEADING", "ScreenHeading");
        public static WinFormsField ContinueMessage = new WinFormsField("CONTINUE-MESSAGE", "ContinueMessage");
        public static WinFormsField CodeDtlLine = new WinFormsField("CODE-DTL-LINE", "CodeDtlLine");
        public static WinFormsField CodeSelLine = new WinFormsField("CODE-SEL-LINE", "CodeSelLine");
        public static WinFormsField DescriptionFilter = new WinFormsField("DESCRIPTION-FILTER", "DescriptionFilter");
        public static WinFormsField EndOFDataMessage = new WinFormsField("END-OF-DATA-MESSAGE", "EndOFDataMessage");
    }
}
