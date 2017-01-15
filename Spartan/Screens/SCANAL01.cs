using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCANAL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCANAL01", "FormName");
		//Fields


        public static WinFormsField ScanalKey0 = new WinFormsField("SCANAL-KEY0", "ScanalKey0");
        public static WinFormsField WorkflowID = new WinFormsField("WORKFLOW-ID", "WorkflowID");
        public static WinFormsField WorkflowSequenceNum = new WinFormsField("WORKFLOW-SEQUENCE-NUM", "WorkflowSequenceNum");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField MsgusrID = new WinFormsField("MSGUSR-ID", "MsgusrID");
        public static WinFormsField TransTypeCode = new WinFormsField("TRANS-TYPE-CODE", "TransTypeCode");
        public static WinFormsField TransTypeCodeParent = new WinFormsField("TRANS-TYPE-CODE-PARENT", "TransTypeCodeParent");
        public static WinFormsField SlotNumber = new WinFormsField("SLOT-NUMBER", "SlotNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
