using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP2002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP2002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField BuySellDesc = new WinFormsField("BUY-SELL-DESC", "BuySellDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        //public static WinFormsField BuySellDesc = new WinFormsField("BUY-SELL-DESC", "BuySellDesc");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderAddress = new WinFormsField("HOLDER-ADDRESS", "HolderAddress");
        public static WinFormsField IssueEmpShares = new WinFormsField("ISSUE-EMP-SHARES", "IssueEmpShares");
        public static WinFormsField OrdinaryClass = new WinFormsField("ORDINARY-CLASS", "OrdinaryClass");
        public static WinFormsField IssueTransNumber = new WinFormsField("ISSUE-TRANS-NUMBER", "IssueTransNumber");
        public static WinFormsField HolderWarnings = new WinFormsField("HOLDER-WARNINGS", "HolderWarnings");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
