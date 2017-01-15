using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDNOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDNOT01", "FormName");
		//Fields


        public static WinFormsField HldnotKey0 = new WinFormsField("HLDNOT-KEY0", "HldnotKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField NotingTypeCode = new WinFormsField("NOTING-TYPE-CODE", "NotingTypeCode");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField StatDecHeldFlag = new WinFormsField("STAT-DEC-HELD-FLAG", "StatDecHeldFlag");
        public static WinFormsField DeathDate = new WinFormsField("DEATH-DATE", "DeathDate");
        public static WinFormsField Sec183State = new WinFormsField("SEC183-STATE", "Sec183State");
        public static WinFormsField DeathSightedDate = new WinFormsField("DEATH-SIGHTED-DATE", "DeathSightedDate");
        public static WinFormsField Sec184State = new WinFormsField("SEC184-STATE", "Sec184State");
        public static WinFormsField WillDate = new WinFormsField("WILL-DATE", "WillDate");
        public static WinFormsField ConfirmID = new WinFormsField("CONFIRM-ID", "ConfirmID");
        public static WinFormsField WillSightedDate = new WinFormsField("WILL-SIGHTED-DATE", "WillSightedDate");
        public static WinFormsField Sec121aSighted = new WinFormsField("SEC-121A-SIGHTED", "Sec121aSighted");
        public static WinFormsField ProbateGrantedDate = new WinFormsField("PROBATE-GRANTED-DATE", "ProbateGrantedDate");
        public static WinFormsField ProbateGrantedIN = new WinFormsField("PROBATE-GRANTED-IN", "ProbateGrantedIN");
        public static WinFormsField ProbateSightedDate = new WinFormsField("PROBATE-SIGHTED-DATE", "ProbateSightedDate");
        public static WinFormsField ResealedIN = new WinFormsField("RESEALED-IN", "ResealedIN");
        public static WinFormsField ResealedDate = new WinFormsField("RESEALED-DATE", "ResealedDate");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField DeceasedNameLine = new WinFormsField("DECEASED-NAME-LINE", "DeceasedNameLine");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
        public static WinFormsField DutyComment = new WinFormsField("DUTY-COMMENT", "DutyComment");
        public static WinFormsField Executor = new WinFormsField("EXECUTOR", "Executor");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField NotingComment3 = new WinFormsField("NOTING-COMMENT-3", "NotingComment3");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
