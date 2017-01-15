using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSHVP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSHVP01", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField TrancheNumber = new WinFormsField("TRANCHE-NUMBER", "TrancheNumber");
        public static WinFormsField PerformanceCode = new WinFormsField("PERFORMANCE-CODE", "PerformanceCode");
        public static WinFormsField TestNumber = new WinFormsField("TEST-NUMBER", "TestNumber");
        public static WinFormsField VestingTermINMonths = new WinFormsField("VESTING-TERM-IN-MONTHS", "VestingTermINMonths");
        public static WinFormsField VestingTermINDays = new WinFormsField("VESTING-TERM-IN-DAYS", "VestingTermINDays");
        public static WinFormsField MonthsFromVestStart = new WinFormsField("MONTHS-FROM-VEST-START", "MonthsFromVestStart");
        public static WinFormsField VestingStartDate = new WinFormsField("VESTING-START-DATE", "VestingStartDate");
        public static WinFormsField DaysFromVestStart = new WinFormsField("DAYS-FROM-VEST-START", "DaysFromVestStart");
        public static WinFormsField ExpiryDate = new WinFormsField("EXPIRY-DATE", "ExpiryDate");
        public static WinFormsField VestingPercentage = new WinFormsField("VESTING-PERCENTAGE", "VestingPercentage");
        public static WinFormsField VestingDate = new WinFormsField("VESTING-DATE", "VestingDate");
        public static WinFormsField TestDate = new WinFormsField("TEST-DATE", "TestDate");
        public static WinFormsField AccelerateDate = new WinFormsField("ACCELERATE-DATE", "AccelerateDate");
        public static WinFormsField TestPercentage = new WinFormsField("TEST-PERCENTAGE", "TestPercentage");
        public static WinFormsField AccelerateUnits = new WinFormsField("ACCELERATE-UNITS", "AccelerateUnits");
        public static WinFormsField CancelUnvestedInd = new WinFormsField("CANCEL-UNVESTED-IND", "CancelUnvestedInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
