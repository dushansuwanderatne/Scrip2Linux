using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    //public class XTT5-D
        public class XTT5D

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("XTT5-D", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HldaddVersion = new WinFormsField("HLDADD-VERSION", "HldaddVersion");
        public static WinFormsField PrintOption = new WinFormsField("PRINT-OPTION", "PrintOption");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ProbateGrantedIN = new WinFormsField("PROBATE-GRANTED-IN", "ProbateGrantedIN");
        public static WinFormsField NotingTypeCode = new WinFormsField("NOTING-TYPE-CODE", "NotingTypeCode");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField ProbateGrantedDate = new WinFormsField("PROBATE-GRANTED-DATE", "ProbateGrantedDate");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField ProbateSightedDate = new WinFormsField("PROBATE-SIGHTED-DATE", "ProbateSightedDate");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField StatDecHeldFlag = new WinFormsField("STAT-DEC-HELD-FLAG", "StatDecHeldFlag");
        public static WinFormsField DeceasedNameLine = new WinFormsField("DECEASED-NAME-LINE", "DeceasedNameLine");
        public static WinFormsField DeathDate = new WinFormsField("DEATH-DATE", "DeathDate");
        public static WinFormsField ResealedIN = new WinFormsField("RESEALED-IN", "ResealedIN");
        public static WinFormsField DeathSightedDate = new WinFormsField("DEATH-SIGHTED-DATE", "DeathSightedDate");
        public static WinFormsField ResealedDate = new WinFormsField("RESEALED-DATE", "ResealedDate");
        public static WinFormsField WillDate = new WinFormsField("WILL-DATE", "WillDate");
        public static WinFormsField Sec183State = new WinFormsField("SEC183-STATE", "Sec183State");
        public static WinFormsField WillSightedDate = new WinFormsField("WILL-SIGHTED-DATE", "WillSightedDate");
        public static WinFormsField Sec184State = new WinFormsField("SEC184-STATE", "Sec184State");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField Filler1 = new WinFormsField("FILLER1", "Filler1");
        public static WinFormsField Executor = new WinFormsField("EXECUTOR", "Executor");
        public static WinFormsField DutyComment = new WinFormsField("DUTY-COMMENT", "DutyComment");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
    }
}
