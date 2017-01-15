using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00416

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00416", "FormName");
		//Fields


        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField RepSequence = new WinFormsField("REP-SEQUENCE", "RepSequence");
        public static WinFormsField PrintHolderID = new WinFormsField("PRINT-HOLDER-ID", "PrintHolderID");
        public static WinFormsField FromRun = new WinFormsField("FROM-RUN", "FromRun");
        public static WinFormsField TORun = new WinFormsField("TO-RUN", "TORun");
        public static WinFormsField VotingLevel = new WinFormsField("VOTING-LEVEL", "VotingLevel");
        public static WinFormsField VotingLevelResolution = new WinFormsField("VOTING-LEVEL-RESOLUTION", "VotingLevelResolution");
    }
}
