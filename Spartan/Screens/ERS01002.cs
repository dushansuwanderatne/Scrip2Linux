using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01002", "FormName");
		//Fields
        public static WinFormsField EmployeeIDFrom = new WinFormsField("EMPLOYEE-ID-FROM", "EmployeeIDFrom");
        public static WinFormsField EmployeeIDTO = new WinFormsField("EMPLOYEE-ID-TO", "EmployeeIDTO");
        public static WinFormsField PayrollID15 = new WinFormsField("PAYROLL-ID-1-5", "PayrollID15");
        public static WinFormsField PayrollID610 = new WinFormsField("PAYROLL-ID-6-10", "PayrollID610");
        public static WinFormsField SubPayrlID15 = new WinFormsField("SUB-PAYRL-ID-1-5", "SubPayrlID15");
        public static WinFormsField SubPayrlID610 = new WinFormsField("SUB-PAYRL-ID-6-10", "SubPayrlID610");
        public static WinFormsField LocationCodeRange = new WinFormsField("LOCATION-CODE-RANGE", "LocationCodeRange");
        public static WinFormsField BusinessUnitsRange = new WinFormsField("BUSINESS-UNITS-RANGE", "BusinessUnitsRange");
        public static WinFormsField JobBandsRange = new WinFormsField("JOB-BANDS-RANGE", "JobBandsRange");
        public static WinFormsField CostCentre13 = new WinFormsField("COST-CENTRE-1-3", "CostCentre13");
        public static WinFormsField CostCentre46 = new WinFormsField("COST-CENTRE-4-6", "CostCentre46");
        public static WinFormsField EmployeeFlag1Range = new WinFormsField("EMPLOYEE-FLAG-1-RANGE", "EmployeeFlag1Range");
        public static WinFormsField EmployeeFlag2Range = new WinFormsField("EMPLOYEE-FLAG-2-RANGE", "EmployeeFlag2Range");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField BlkoutRstrctdInd = new WinFormsField("BLKOUT-RSTRCTD-IND", "BlkoutRstrctdInd");
        public static WinFormsField BlkoutRstrctdCode = new WinFormsField("BLKOUT-RSTRCTD-CODE", "BlkoutRstrctdCode");
        public static WinFormsField EffDateFrom = new WinFormsField("EFF-DATE-FROM", "EffDateFrom");
        public static WinFormsField EffDateTO = new WinFormsField("EFF-DATE-TO", "EffDateTO");
        public static WinFormsField StartDateFrom = new WinFormsField("START-DATE-FROM", "StartDateFrom");
        public static WinFormsField StartDateTO = new WinFormsField("START-DATE-TO", "StartDateTO");
        public static WinFormsField ResidDateFrom = new WinFormsField("RESID-DATE-FROM", "ResidDateFrom");
        public static WinFormsField ResidDateTO = new WinFormsField("RESID-DATE-TO", "ResidDateTO");
        public static WinFormsField HoldEndDateFrom = new WinFormsField("HOLD-END-DATE-FROM", "HoldEndDateFrom");
        public static WinFormsField HoldEndDateTO = new WinFormsField("HOLD-END-DATE-TO", "HoldEndDateTO");
        public static WinFormsField TaxEndDateFrom = new WinFormsField("TAX-END-DATE-FROM", "TaxEndDateFrom");
        public static WinFormsField TaxEndDateTO = new WinFormsField("TAX-END-DATE-TO", "TaxEndDateTO");
        public static WinFormsField LeaverPackSentFrom = new WinFormsField("LEAVER-PACK-SENT-FROM", "LeaverPackSentFrom");
        public static WinFormsField LeaverPackSentTO = new WinFormsField("LEAVER-PACK-SENT-TO", "LeaverPackSentTO");
        public static WinFormsField GspEmployees = new WinFormsField("GSP-EMPLOYEES", "GspEmployees");
        public static WinFormsField IncludeUnawInd = new WinFormsField("INCLUDE-UNAW-IND", "IncludeUnawInd");
        public static WinFormsField DomCodes = new WinFormsField("DOM-CODES", "DomCodes");
        public static WinFormsField DomcodeFlag = new WinFormsField("DOMCODE-FLAG", "DomcodeFlag");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField ExcludeFlag = new WinFormsField("EXCLUDE-FLAG", "ExcludeFlag");
        public static WinFormsField EmployeeFilename = new WinFormsField("EMPLOYEE-FILENAME", "EmployeeFilename");
        public static WinFormsField OutputFilename = new WinFormsField("OUTPUT-FILENAME", "OutputFilename");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
