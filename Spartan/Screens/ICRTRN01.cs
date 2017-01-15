using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICRTRN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICRTRN01", "FormName");
		//Fields


        public static WinFormsField CompanyRefX = new WinFormsField("COMPANY-REF-X", "CompanyRefX");
        public static WinFormsField TransNbr = new WinFormsField("TRANS-NBR", "TransNbr");
        public static WinFormsField SequenceNbr = new WinFormsField("SEQUENCE-NBR", "SequenceNbr");
        public static WinFormsField IcrType = new WinFormsField("ICR-TYPE", "IcrType");
        public static WinFormsField GroupID = new WinFormsField("GROUP-ID", "GroupID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField ToleranceEndDate = new WinFormsField("TOLERANCE-END-DATE", "ToleranceEndDate");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField ReasonCode = new WinFormsField("REASON-CODE", "ReasonCode");
        public static WinFormsField ReconType = new WinFormsField("RECON-TYPE", "ReconType");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField EnteredDate = new WinFormsField("ENTERED-DATE", "EnteredDate");
        public static WinFormsField EnteredTimeHhmmss = new WinFormsField("ENTERED-TIME-HHMMSS", "EnteredTimeHhmmss");
        public static WinFormsField EnteredServCode = new WinFormsField("ENTERED-SERV-CODE", "EnteredServCode");
        public static WinFormsField EnteredServProv = new WinFormsField("ENTERED-SERV-PROV", "EnteredServProv");
        public static WinFormsField EnteredOrigSystem = new WinFormsField("ENTERED-ORIG-SYSTEM", "EnteredOrigSystem");
        public static WinFormsField EnteredBranch = new WinFormsField("ENTERED-BRANCH", "EnteredBranch");
        public static WinFormsField EnteredMsgid = new WinFormsField("ENTERED-MSGID", "EnteredMsgid");
        public static WinFormsField EnteredDept = new WinFormsField("ENTERED-DEPT", "EnteredDept");
        public static WinFormsField EnteredInitial = new WinFormsField("ENTERED-INITIAL", "EnteredInitial");
        public static WinFormsField EnteredSurname = new WinFormsField("ENTERED-SURNAME", "EnteredSurname");
        public static WinFormsField EnteredGivenName = new WinFormsField("ENTERED-GIVEN-NAME", "EnteredGivenName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
