using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM15

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM15", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField NotingIdentifier = new WinFormsField("NOTING-IDENTIFIER", "NotingIdentifier");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField DeceasedNameLine = new WinFormsField("DECEASED-NAME-LINE", "DeceasedNameLine");
        public static WinFormsField ADeceasedNameLine = new WinFormsField("A-DECEASED-NAME-LINE", "ADeceasedNameLine");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField ARegister = new WinFormsField("A-REGISTER", "ARegister");
        public static WinFormsField DeathDate = new WinFormsField("DEATH-DATE", "DeathDate");
        public static WinFormsField ADeathDate = new WinFormsField("A-DEATH-DATE", "ADeathDate");
        public static WinFormsField Executor = new WinFormsField("EXECUTOR", "Executor");
        public static WinFormsField DeathSightedDate = new WinFormsField("DEATH-SIGHTED-DATE", "DeathSightedDate");
        public static WinFormsField ADeathSightedDate = new WinFormsField("A-DEATH-SIGHTED-DATE", "ADeathSightedDate");
        public static WinFormsField WillDate = new WinFormsField("WILL-DATE", "WillDate");
        public static WinFormsField AWillDate = new WinFormsField("A-WILL-DATE", "AWillDate");
        public static WinFormsField DutyComment = new WinFormsField("DUTY-COMMENT", "DutyComment");
        public static WinFormsField WillSightedDate = new WinFormsField("WILL-SIGHTED-DATE", "WillSightedDate");
        public static WinFormsField AWillSightedDate = new WinFormsField("A-WILL-SIGHTED-DATE", "AWillSightedDate");
        public static WinFormsField AExecutor = new WinFormsField("A-EXECUTOR", "AExecutor");
        public static WinFormsField StatDecHeldFlag = new WinFormsField("STAT-DEC-HELD-FLAG", "StatDecHeldFlag");
        public static WinFormsField AStatDecHeldFlag = new WinFormsField("A-STAT-DEC-HELD-FLAG", "AStatDecHeldFlag");
        public static WinFormsField ADutyComment = new WinFormsField("A-DUTY-COMMENT", "ADutyComment");
        public static WinFormsField ConfirmID = new WinFormsField("CONFIRM-ID", "ConfirmID");
        public static WinFormsField AConfirmID = new WinFormsField("A-CONFIRM-ID", "AConfirmID");
        public static WinFormsField ProbateGrantedIN = new WinFormsField("PROBATE-GRANTED-IN", "ProbateGrantedIN");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField AProbateGrantIN = new WinFormsField("A-PROBATE-GRANT-IN", "AProbateGrantIN");
        public static WinFormsField ProbateGrantedDate = new WinFormsField("PROBATE-GRANTED-DATE", "ProbateGrantedDate");
        public static WinFormsField AProbateGrantDate = new WinFormsField("A-PROBATE-GRANT-DATE", "AProbateGrantDate");
        public static WinFormsField ProbateSightedDate = new WinFormsField("PROBATE-SIGHTED-DATE", "ProbateSightedDate");
        public static WinFormsField AProbateSightDate = new WinFormsField("A-PROBATE-SIGHT-DATE", "AProbateSightDate");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
        public static WinFormsField ResealedIN = new WinFormsField("RESEALED-IN", "ResealedIN");
        public static WinFormsField ANotingComment70 = new WinFormsField("A-NOTING-COMMENT70", "ANotingComment70");
        public static WinFormsField AResealedIN = new WinFormsField("A-RESEALED-IN", "AResealedIN");
        public static WinFormsField ResealedDate = new WinFormsField("RESEALED-DATE", "ResealedDate");
        public static WinFormsField AResealedDate = new WinFormsField("A-RESEALED-DATE", "AResealedDate");
        public static WinFormsField Sec183State = new WinFormsField("SEC183-STATE", "Sec183State");
        public static WinFormsField ALodgedBYComment = new WinFormsField("A-LODGED-BY-COMMENT", "ALodgedBYComment");
        public static WinFormsField ASec183State = new WinFormsField("A-SEC183-STATE", "ASec183State");
        public static WinFormsField Sec121aSighted = new WinFormsField("SEC-121A-SIGHTED", "Sec121aSighted");
        public static WinFormsField ASec121aSighted = new WinFormsField("A-SEC-121A-SIGHTED", "ASec121aSighted");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
