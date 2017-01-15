using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS21002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS21002", "FormName");
		//Fields


        public static WinFormsField Client = new WinFormsField("CLIENT", "Client");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField RtnUserName = new WinFormsField("RTN-USER-NAME", "RtnUserName");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField StartRunNbr = new WinFormsField("START-RUN-NBR", "StartRunNbr");
        public static WinFormsField EndRunNbr = new WinFormsField("END-RUN-NBR", "EndRunNbr");
        public static WinFormsField RepSequence = new WinFormsField("REP-SEQUENCE", "RepSequence");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
