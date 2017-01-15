using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL02704

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL02704", "FormName");
		//Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassCodeDesc = new WinFormsField("CLASS-CODE-DESC", "ClassCodeDesc");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField EffectiveDate = new WinFormsField("EFFECTIVE-DATE", "EffectiveDate");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField LeaverProcessingDate = new WinFormsField("LEAVER-PROCESSING-DATE", "LeaverProcessingDate");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField RegType = new WinFormsField("REG-TYPE", "RegType");
        public static WinFormsField NOChangeUvst = new WinFormsField("NO-CHANGE-UVST", "NOChangeUvst");
        public static WinFormsField CancelImmUvst = new WinFormsField("CANCEL-IMM-UVST", "CancelImmUvst");
        public static WinFormsField VestNbrUvst = new WinFormsField("VEST-NBR-UVST", "VestNbrUvst");
        public static WinFormsField VestDateUvst = new WinFormsField("VEST-DATE-UVST", "VestDateUvst");
        public static WinFormsField ExpireNbrUvst = new WinFormsField("EXPIRE-NBR-UVST", "ExpireNbrUvst");
        public static WinFormsField NOChangeVst = new WinFormsField("NO-CHANGE-VST", "NOChangeVst");
        public static WinFormsField CancelImmVst = new WinFormsField("CANCEL-IMM-VST", "CancelImmVst");
        public static WinFormsField ExpireNbrVst = new WinFormsField("EXPIRE-NBR-VST", "ExpireNbrVst");
        public static WinFormsField ExpiryDate = new WinFormsField("EXPIRY-DATE", "ExpiryDate");
        public static WinFormsField IgnoreBlackoutInd = new WinFormsField("IGNORE-BLACKOUT-IND", "IgnoreBlackoutInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
