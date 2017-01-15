using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM35

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM35", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField ChildTranTypeCode = new WinFormsField("CHILD-TRAN-TYPE-CODE", "ChildTranTypeCode");
        public static WinFormsField ChildTranTypeDesc = new WinFormsField("CHILD-TRAN-TYPE-DESC", "ChildTranTypeDesc");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField TranRecCount = new WinFormsField("TRAN-REC-COUNT", "TranRecCount");
        public static WinFormsField OldClassCode = new WinFormsField("OLD-CLASS-CODE", "OldClassCode");
        public static WinFormsField OldStatusDescription = new WinFormsField("OLD-STATUS-DESCRIPTION", "OldStatusDescription");
        public static WinFormsField OldParticipationOpt = new WinFormsField("OLD-PARTICIPATION-OPT", "OldParticipationOpt");
        public static WinFormsField OldParticipationLvl = new WinFormsField("OLD-PARTICIPATION-LVL", "OldParticipationLvl");
        public static WinFormsField OldCharityCode = new WinFormsField("OLD-CHARITY-CODE", "OldCharityCode");
        public static WinFormsField NewClassCode = new WinFormsField("NEW-CLASS-CODE", "NewClassCode");
        public static WinFormsField NewStatusDescription = new WinFormsField("NEW-STATUS-DESCRIPTION", "NewStatusDescription");
        public static WinFormsField NewPenTranCode = new WinFormsField("NEW-PEN-TRAN-CODE", "NewPenTranCode");
        public static WinFormsField NewParticipationOpt = new WinFormsField("NEW-PARTICIPATION-OPT", "NewParticipationOpt");
        public static WinFormsField NewParticipationLvl = new WinFormsField("NEW-PARTICIPATION-LVL", "NewParticipationLvl");
        public static WinFormsField NewCharityCode = new WinFormsField("NEW-CHARITY-CODE", "NewCharityCode");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
