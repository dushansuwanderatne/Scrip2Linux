using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL02702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL02702", "FormName");
		//Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField EffectiveDate = new WinFormsField("EFFECTIVE-DATE", "EffectiveDate");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField LvrProcessingDate = new WinFormsField("LVR-PROCESSING-DATE", "LvrProcessingDate");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassCodeDesc = new WinFormsField("CLASS-CODE-DESC", "ClassCodeDesc");
        public static WinFormsField IgnoreBlackoutInd = new WinFormsField("IGNORE-BLACKOUT-IND", "IgnoreBlackoutInd");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField CurrBalUvst = new WinFormsField("CURR-BAL-UVST", "CurrBalUvst");
        public static WinFormsField NOChangeUvst1 = new WinFormsField("NO-CHANGE-UVST-1", "NOChangeUvst1");
        public static WinFormsField CancelImmUvst1 = new WinFormsField("CANCEL-IMM-UVST-1", "CancelImmUvst1");
        public static WinFormsField VestNbrUvst1 = new WinFormsField("VEST-NBR-UVST-1", "VestNbrUvst1");
        public static WinFormsField VestDateUvst1 = new WinFormsField("VEST-DATE-UVST-1", "VestDateUvst1");
        public static WinFormsField CurrBalVst = new WinFormsField("CURR-BAL-VST", "CurrBalVst");
        public static WinFormsField NOChangeVst1 = new WinFormsField("NO-CHANGE-VST-1", "NOChangeVst1");
        public static WinFormsField CancelImmVst1 = new WinFormsField("CANCEL-IMM-VST-1", "CancelImmVst1");
        public static WinFormsField ExpiryDate1 = new WinFormsField("EXPIRY-DATE-1", "ExpiryDate1");
        public static WinFormsField NOChangeUvst2 = new WinFormsField("NO-CHANGE-UVST-2", "NOChangeUvst2");
        public static WinFormsField CancelImmUvst2 = new WinFormsField("CANCEL-IMM-UVST-2", "CancelImmUvst2");
        public static WinFormsField VestNbrUvst2 = new WinFormsField("VEST-NBR-UVST-2", "VestNbrUvst2");
        public static WinFormsField VestDateUvst2 = new WinFormsField("VEST-DATE-UVST-2", "VestDateUvst2");
        public static WinFormsField NOChangeVst2 = new WinFormsField("NO-CHANGE-VST-2", "NOChangeVst2");
        public static WinFormsField CancelImmVst2 = new WinFormsField("CANCEL-IMM-VST-2", "CancelImmVst2");
        public static WinFormsField ExpiryDate2 = new WinFormsField("EXPIRY-DATE-2", "ExpiryDate2");
        public static WinFormsField NOChangeUvst3 = new WinFormsField("NO-CHANGE-UVST-3", "NOChangeUvst3");
        public static WinFormsField CancelImmUvst3 = new WinFormsField("CANCEL-IMM-UVST-3", "CancelImmUvst3");
        public static WinFormsField VestNbrUvst3 = new WinFormsField("VEST-NBR-UVST-3", "VestNbrUvst3");
        public static WinFormsField VestDateUvst3 = new WinFormsField("VEST-DATE-UVST-3", "VestDateUvst3");
        public static WinFormsField NOChangeVst3 = new WinFormsField("NO-CHANGE-VST-3", "NOChangeVst3");
        public static WinFormsField CancelImmVst3 = new WinFormsField("CANCEL-IMM-VST-3", "CancelImmVst3");
        public static WinFormsField ExpiryDate3 = new WinFormsField("EXPIRY-DATE-3", "ExpiryDate3");
        public static WinFormsField NOChangeUvst4 = new WinFormsField("NO-CHANGE-UVST-4", "NOChangeUvst4");
        public static WinFormsField CancelImmUvst4 = new WinFormsField("CANCEL-IMM-UVST-4", "CancelImmUvst4");
        public static WinFormsField VestNbrUvst4 = new WinFormsField("VEST-NBR-UVST-4", "VestNbrUvst4");
        public static WinFormsField VestDateUvst4 = new WinFormsField("VEST-DATE-UVST-4", "VestDateUvst4");
        public static WinFormsField NOChangeVst4 = new WinFormsField("NO-CHANGE-VST-4", "NOChangeVst4");
        public static WinFormsField CancelImmVst4 = new WinFormsField("CANCEL-IMM-VST-4", "CancelImmVst4");
        public static WinFormsField ExpiryDate4 = new WinFormsField("EXPIRY-DATE-4", "ExpiryDate4");
        public static WinFormsField NOChangeUvst5 = new WinFormsField("NO-CHANGE-UVST-5", "NOChangeUvst5");
        public static WinFormsField CancelImmUvst5 = new WinFormsField("CANCEL-IMM-UVST-5", "CancelImmUvst5");
        public static WinFormsField VestNbrUvst5 = new WinFormsField("VEST-NBR-UVST-5", "VestNbrUvst5");
        public static WinFormsField VestDateUvst5 = new WinFormsField("VEST-DATE-UVST-5", "VestDateUvst5");
        public static WinFormsField NOChangeVst5 = new WinFormsField("NO-CHANGE-VST-5", "NOChangeVst5");
        public static WinFormsField CancelImmVst5 = new WinFormsField("CANCEL-IMM-VST-5", "CancelImmVst5");
        public static WinFormsField ExpiryDate5 = new WinFormsField("EXPIRY-DATE-5", "ExpiryDate5");
        public static WinFormsField NOChangeUvst6 = new WinFormsField("NO-CHANGE-UVST-6", "NOChangeUvst6");
        public static WinFormsField CancelImmUvst6 = new WinFormsField("CANCEL-IMM-UVST-6", "CancelImmUvst6");
        public static WinFormsField VestNbrUvst6 = new WinFormsField("VEST-NBR-UVST-6", "VestNbrUvst6");
        public static WinFormsField VestDateUvst6 = new WinFormsField("VEST-DATE-UVST-6", "VestDateUvst6");
        public static WinFormsField NOChangeVst6 = new WinFormsField("NO-CHANGE-VST-6", "NOChangeVst6");
        public static WinFormsField CancelImmVst6 = new WinFormsField("CANCEL-IMM-VST-6", "CancelImmVst6");
        public static WinFormsField ExpiryDate6 = new WinFormsField("EXPIRY-DATE-6", "ExpiryDate6");
        public static WinFormsField NOChangeUvst7 = new WinFormsField("NO-CHANGE-UVST-7", "NOChangeUvst7");
        public static WinFormsField CancelImmUvst7 = new WinFormsField("CANCEL-IMM-UVST-7", "CancelImmUvst7");
        public static WinFormsField VestNbrUvst7 = new WinFormsField("VEST-NBR-UVST-7", "VestNbrUvst7");
        public static WinFormsField VestDateUvst7 = new WinFormsField("VEST-DATE-UVST-7", "VestDateUvst7");
        public static WinFormsField NOChangeVst7 = new WinFormsField("NO-CHANGE-VST-7", "NOChangeVst7");
        public static WinFormsField CancelImmVst7 = new WinFormsField("CANCEL-IMM-VST-7", "CancelImmVst7");
        public static WinFormsField ExpiryDate7 = new WinFormsField("EXPIRY-DATE-7", "ExpiryDate7");
        public static WinFormsField NOChangeUvst8 = new WinFormsField("NO-CHANGE-UVST-8", "NOChangeUvst8");
        public static WinFormsField CancelImmUvst8 = new WinFormsField("CANCEL-IMM-UVST-8", "CancelImmUvst8");
        public static WinFormsField VestNbrUvst8 = new WinFormsField("VEST-NBR-UVST-8", "VestNbrUvst8");
        public static WinFormsField VestDateUvst8 = new WinFormsField("VEST-DATE-UVST-8", "VestDateUvst8");
        public static WinFormsField NOChangeVst8 = new WinFormsField("NO-CHANGE-VST-8", "NOChangeVst8");
        public static WinFormsField CancelImmVst8 = new WinFormsField("CANCEL-IMM-VST-8", "CancelImmVst8");
        public static WinFormsField ExpiryDate8 = new WinFormsField("EXPIRY-DATE-8", "ExpiryDate8");
        public static WinFormsField NOChangeUvst9 = new WinFormsField("NO-CHANGE-UVST-9", "NOChangeUvst9");
        public static WinFormsField CancelImmUvst9 = new WinFormsField("CANCEL-IMM-UVST-9", "CancelImmUvst9");
        public static WinFormsField VestNbrUvst9 = new WinFormsField("VEST-NBR-UVST-9", "VestNbrUvst9");
        public static WinFormsField VestDateUvst9 = new WinFormsField("VEST-DATE-UVST-9", "VestDateUvst9");
        public static WinFormsField NOChangeVst9 = new WinFormsField("NO-CHANGE-VST-9", "NOChangeVst9");
        public static WinFormsField CancelImmVst9 = new WinFormsField("CANCEL-IMM-VST-9", "CancelImmVst9");
        public static WinFormsField ExpiryDate9 = new WinFormsField("EXPIRY-DATE-9", "ExpiryDate9");
        public static WinFormsField NOChangeUvst10 = new WinFormsField("NO-CHANGE-UVST-10", "NOChangeUvst10");
        public static WinFormsField CancelImmUvst10 = new WinFormsField("CANCEL-IMM-UVST-10", "CancelImmUvst10");
        public static WinFormsField VestNbrUvst10 = new WinFormsField("VEST-NBR-UVST-10", "VestNbrUvst10");
        public static WinFormsField VestDateUvst10 = new WinFormsField("VEST-DATE-UVST-10", "VestDateUvst10");
        public static WinFormsField NOChangeVst10 = new WinFormsField("NO-CHANGE-VST-10", "NOChangeVst10");
        public static WinFormsField CancelImmVst10 = new WinFormsField("CANCEL-IMM-VST-10", "CancelImmVst10");
        public static WinFormsField ExpiryDate10 = new WinFormsField("EXPIRY-DATE-10", "ExpiryDate10");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
