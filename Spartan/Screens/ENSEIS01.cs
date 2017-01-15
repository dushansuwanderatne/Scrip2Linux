using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEIS01", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField EmployeeNumber = new WinFormsField("EMPLOYEE-NUMBER", "EmployeeNumber");
        public static WinFormsField SubPayrollID = new WinFormsField("SUB-PAYROLL-ID", "SubPayrollID");
        public static WinFormsField EmployeeUniqueID = new WinFormsField("EMPLOYEE-UNIQUE-ID", "EmployeeUniqueID");
        public static WinFormsField NationalInsNbr = new WinFormsField("NATIONAL-INS-NBR", "NationalInsNbr");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField TermDate = new WinFormsField("TERM-DATE", "TermDate");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField TermDesc = new WinFormsField("TERM-DESC", "TermDesc");
        public static WinFormsField EmployeeFlag1 = new WinFormsField("EMPLOYEE-FLAG-1", "EmployeeFlag1");
        public static WinFormsField TermType = new WinFormsField("TERM-TYPE", "TermType");
        public static WinFormsField EmployeeFlag2 = new WinFormsField("EMPLOYEE-FLAG-2", "EmployeeFlag2");
        public static WinFormsField PendingDate = new WinFormsField("PENDING-DATE", "PendingDate");
        public static WinFormsField GspEmployeeInd = new WinFormsField("GSP-EMPLOYEE-IND", "GspEmployeeInd");
        public static WinFormsField PreferredName = new WinFormsField("PREFERRED-NAME", "PreferredName");
        public static WinFormsField BirthDate = new WinFormsField("BIRTH-DATE", "BirthDate");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField LeaverPack = new WinFormsField("LEAVER-PACK", "LeaverPack");
        public static WinFormsField LeaverPackSentDT = new WinFormsField("LEAVER-PACK-SENT-DT", "LeaverPackSentDT");
        public static WinFormsField EmployeeStatus = new WinFormsField("EMPLOYEE-STATUS", "EmployeeStatus");
        public static WinFormsField AutoForfeitureInd = new WinFormsField("AUTO-FORFEITURE-IND", "AutoForfeitureInd");
        public static WinFormsField StatusDescription = new WinFormsField("STATUS-DESCRIPTION", "StatusDescription");
        public static WinFormsField EffectiveDate = new WinFormsField("EFFECTIVE-DATE", "EffectiveDate");
        public static WinFormsField BlkoutRstrctdInd = new WinFormsField("BLKOUT-RSTRCTD-IND", "BlkoutRstrctdInd");
        public static WinFormsField BlkoutRstrctdCode = new WinFormsField("BLKOUT-RSTRCTD-CODE", "BlkoutRstrctdCode");
        public static WinFormsField BlkoutRstrctdDesc = new WinFormsField("BLKOUT-RSTRCTD-DESC", "BlkoutRstrctdDesc");
        public static WinFormsField LocationCode = new WinFormsField("LOCATION-CODE", "LocationCode");
        public static WinFormsField BusinessUnit = new WinFormsField("BUSINESS-UNIT", "BusinessUnit");
        public static WinFormsField JobBand = new WinFormsField("JOB-BAND", "JobBand");
        public static WinFormsField Hvf1IDDesc = new WinFormsField("HVF1-ID-DESC", "Hvf1IDDesc");
        public static WinFormsField Hvf1Value = new WinFormsField("HVF1-VALUE", "Hvf1Value");
        public static WinFormsField Hvf1Desc = new WinFormsField("HVF1-DESC", "Hvf1Desc");
        public static WinFormsField CostCentre = new WinFormsField("COST-CENTRE", "CostCentre");
        public static WinFormsField Hvf2IDDesc = new WinFormsField("HVF2-ID-DESC", "Hvf2IDDesc");
        public static WinFormsField Hvf2Value = new WinFormsField("HVF2-VALUE", "Hvf2Value");
        public static WinFormsField Hvf2Desc = new WinFormsField("HVF2-DESC", "Hvf2Desc");
        public static WinFormsField Hvf3IDDesc = new WinFormsField("HVF3-ID-DESC", "Hvf3IDDesc");
        public static WinFormsField Hvf3Value = new WinFormsField("HVF3-VALUE", "Hvf3Value");
        public static WinFormsField Hvf3Desc = new WinFormsField("HVF3-DESC", "Hvf3Desc");
        public static WinFormsField Hvf4IDDesc = new WinFormsField("HVF4-ID-DESC", "Hvf4IDDesc");
        public static WinFormsField Hvf4Value = new WinFormsField("HVF4-VALUE", "Hvf4Value");
        public static WinFormsField Hvf4Desc = new WinFormsField("HVF4-DESC", "Hvf4Desc");
        public static WinFormsField Hvf5IDDesc = new WinFormsField("HVF5-ID-DESC", "Hvf5IDDesc");
        public static WinFormsField Hvf5Value = new WinFormsField("HVF5-VALUE", "Hvf5Value");
        public static WinFormsField Hvf5Desc = new WinFormsField("HVF5-DESC", "Hvf5Desc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
