using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSAPR02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSAPR02", "FormName");
		//Fields


        public static WinFormsField EssaprKey0 = new WinFormsField("ESSAPR-KEY0", "EssaprKey0");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField EssaprKey1 = new WinFormsField("ESSAPR-KEY1", "EssaprKey1");
        public static WinFormsField ReportUpdateMode = new WinFormsField("REPORT-UPDATE-MODE", "ReportUpdateMode");
        public static WinFormsField StartCrtTransNbr = new WinFormsField("START-CRT-TRANS-NBR", "StartCrtTransNbr");
        public static WinFormsField NameSelection = new WinFormsField("NAME-SELECTION", "NameSelection");
        public static WinFormsField EndCrtTransNbr = new WinFormsField("END-CRT-TRANS-NBR", "EndCrtTransNbr");
        public static WinFormsField PostcodeCheck = new WinFormsField("POSTCODE-CHECK", "PostcodeCheck");
        public static WinFormsField StartEssTransNbr = new WinFormsField("START-ESS-TRANS-NBR", "StartEssTransNbr");
        public static WinFormsField CheckUnits = new WinFormsField("CHECK-UNITS", "CheckUnits");
        public static WinFormsField EndEssTransNbr = new WinFormsField("END-ESS-TRANS-NBR", "EndEssTransNbr");
        public static WinFormsField LastRunNumber = new WinFormsField("LAST-RUN-NUMBER", "LastRunNumber");
        public static WinFormsField ErrorCnt = new WinFormsField("ERROR-CNT", "ErrorCnt");
        public static WinFormsField InputRecCnt = new WinFormsField("INPUT-REC-CNT", "InputRecCnt");
        public static WinFormsField DifferenceCnt = new WinFormsField("DIFFERENCE-CNT", "DifferenceCnt");
        public static WinFormsField NewHolderCnt = new WinFormsField("NEW-HOLDER-CNT", "NewHolderCnt");
        public static WinFormsField WarningCnt = new WinFormsField("WARNING-CNT", "WarningCnt");
        public static WinFormsField TransCnt = new WinFormsField("TRANS-CNT", "TransCnt");
        public static WinFormsField EmpDetailsCnt = new WinFormsField("EMP-DETAILS-CNT", "EmpDetailsCnt");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
