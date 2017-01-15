using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDCOM01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDCOM01", "FormName");
		//Fields


        public static WinFormsField PndcomKey0 = new WinFormsField("PNDCOM-KEY0", "PndcomKey0");
        public static WinFormsField PendingRunNumber = new WinFormsField("PENDING-RUN-NUMBER", "PendingRunNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField StatusInd = new WinFormsField("STATUS-IND", "StatusInd");
        public static WinFormsField DocType = new WinFormsField("DOC-TYPE", "DocType");
        public static WinFormsField ReasonCode = new WinFormsField("REASON-CODE", "ReasonCode");
        public static WinFormsField CompletedRunNumber = new WinFormsField("COMPLETED-RUN-NUMBER", "CompletedRunNumber");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField ReasonNotSent = new WinFormsField("REASON-NOT-SENT", "ReasonNotSent");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
