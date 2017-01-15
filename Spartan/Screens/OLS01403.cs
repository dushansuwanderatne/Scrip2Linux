using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01403", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField TransNbrI = new WinFormsField("TRANS-NBR-I", "TransNbrI");
        public static WinFormsField TransDateI = new WinFormsField("TRANS-DATE-I", "TransDateI");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField DeceasedNameLine = new WinFormsField("DECEASED-NAME-LINE", "DeceasedNameLine");
        public static WinFormsField DeathDate = new WinFormsField("DEATH-DATE", "DeathDate");
        public static WinFormsField DeathSightedDate = new WinFormsField("DEATH-SIGHTED-DATE", "DeathSightedDate");
        public static WinFormsField WillDate = new WinFormsField("WILL-DATE", "WillDate");
        public static WinFormsField WillSightedDate = new WinFormsField("WILL-SIGHTED-DATE", "WillSightedDate");
        public static WinFormsField StatDecHeldFlag = new WinFormsField("STAT-DEC-HELD-FLAG", "StatDecHeldFlag");
        public static WinFormsField ProbateGrantedIN = new WinFormsField("PROBATE-GRANTED-IN", "ProbateGrantedIN");
        public static WinFormsField ProbateGrantedDate = new WinFormsField("PROBATE-GRANTED-DATE", "ProbateGrantedDate");
        public static WinFormsField ProbateSightedDate = new WinFormsField("PROBATE-SIGHTED-DATE", "ProbateSightedDate");
        public static WinFormsField ResealedIN = new WinFormsField("RESEALED-IN", "ResealedIN");
        public static WinFormsField ResealedDate = new WinFormsField("RESEALED-DATE", "ResealedDate");
        public static WinFormsField Sec183State = new WinFormsField("SEC183-STATE", "Sec183State");
        public static WinFormsField SightedInd121a = new WinFormsField("121A-SIGHTED-IND", "121aSightedInd");
        public static WinFormsField ConfirmIDInd = new WinFormsField("CONFIRM-ID-IND", "ConfirmIDInd");
        public static WinFormsField Executor = new WinFormsField("EXECUTOR", "Executor");
        public static WinFormsField DutyComment = new WinFormsField("DUTY-COMMENT", "DutyComment");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField LodgedBYCommentX = new WinFormsField("LODGED-BY-COMMENT-X", "LodgedBYCommentX");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionDesc = new WinFormsField("ACTION-DESC", "ActionDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
