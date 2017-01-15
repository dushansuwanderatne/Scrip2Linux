using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM05", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField OldNationalInsNbr = new WinFormsField("OLD-NATIONAL-INS-NBR", "OldNationalInsNbr");
        public static WinFormsField NewNationalInsNbr = new WinFormsField("NEW-NATIONAL-INS-NBR", "NewNationalInsNbr");
        public static WinFormsField OldEmployeeStatus = new WinFormsField("OLD-EMPLOYEE-STATUS", "OldEmployeeStatus");
        public static WinFormsField NewEmployeeStatus = new WinFormsField("NEW-EMPLOYEE-STATUS", "NewEmployeeStatus");
        public static WinFormsField OldEmplNumber = new WinFormsField("OLD-EMPL-NUMBER", "OldEmplNumber");
        public static WinFormsField NewEmplNumber = new WinFormsField("NEW-EMPL-NUMBER", "NewEmplNumber");
        public static WinFormsField OldRetirementInd = new WinFormsField("OLD-RETIREMENT-IND", "OldRetirementInd");
        public static WinFormsField NewRetirementInd = new WinFormsField("NEW-RETIREMENT-IND", "NewRetirementInd");
        public static WinFormsField OldEmpUniqueID = new WinFormsField("OLD-EMP-UNIQUE-ID", "OldEmpUniqueID");
        public static WinFormsField OldLeaverPack = new WinFormsField("OLD-LEAVER-PACK", "OldLeaverPack");
        public static WinFormsField NewLeaverPack = new WinFormsField("NEW-LEAVER-PACK", "NewLeaverPack");
        public static WinFormsField NewEmpUniqueID = new WinFormsField("NEW-EMP-UNIQUE-ID", "NewEmpUniqueID");
        public static WinFormsField OldAutoForfeitInd = new WinFormsField("OLD-AUTO-FORFEIT-IND", "OldAutoForfeitInd");
        public static WinFormsField NewAutoForfeitInd = new WinFormsField("NEW-AUTO-FORFEIT-IND", "NewAutoForfeitInd");
        public static WinFormsField OldPayrollIdentifier = new WinFormsField("OLD-PAYROLL-IDENTIFIER", "OldPayrollIdentifier");
        public static WinFormsField NewPayrollIdentifier = new WinFormsField("NEW-PAYROLL-IDENTIFIER", "NewPayrollIdentifier");
        public static WinFormsField OldLeaverCode = new WinFormsField("OLD-LEAVER-CODE", "OldLeaverCode");
        public static WinFormsField NewLeaverCode = new WinFormsField("NEW-LEAVER-CODE", "NewLeaverCode");
        public static WinFormsField OldSubPayrollID = new WinFormsField("OLD-SUB-PAYROLL-ID", "OldSubPayrollID");
        public static WinFormsField NewSubPayrollID = new WinFormsField("NEW-SUB-PAYROLL-ID", "NewSubPayrollID");
        public static WinFormsField OldPreferredName = new WinFormsField("OLD-PREFERRED-NAME", "OldPreferredName");
        public static WinFormsField NewPreferredName = new WinFormsField("NEW-PREFERRED-NAME", "NewPreferredName");
        public static WinFormsField OldEffectiveDate = new WinFormsField("OLD-EFFECTIVE-DATE", "OldEffectiveDate");
        public static WinFormsField NewEffectiveDate = new WinFormsField("NEW-EFFECTIVE-DATE", "NewEffectiveDate");
        public static WinFormsField OldStartDate = new WinFormsField("OLD-START-DATE", "OldStartDate");
        public static WinFormsField NewStartDate = new WinFormsField("NEW-START-DATE", "NewStartDate");
        public static WinFormsField OldSex = new WinFormsField("OLD-SEX", "OldSex");
        public static WinFormsField NewSex = new WinFormsField("NEW-SEX", "NewSex");
        public static WinFormsField OldTermDate = new WinFormsField("OLD-TERM-DATE", "OldTermDate");
        public static WinFormsField NewTermDate = new WinFormsField("NEW-TERM-DATE", "NewTermDate");
        public static WinFormsField OldBirthDate = new WinFormsField("OLD-BIRTH-DATE", "OldBirthDate");
        public static WinFormsField NewBirthDate = new WinFormsField("NEW-BIRTH-DATE", "NewBirthDate");
        public static WinFormsField OldTerminationDesc = new WinFormsField("OLD-TERMINATION-DESC", "OldTerminationDesc");
        public static WinFormsField NewTerminationDesc = new WinFormsField("NEW-TERMINATION-DESC", "NewTerminationDesc");
        public static WinFormsField OldLocationCode = new WinFormsField("OLD-LOCATION-CODE", "OldLocationCode");
        public static WinFormsField NewLocationCode = new WinFormsField("NEW-LOCATION-CODE", "NewLocationCode");
        public static WinFormsField OldEmployeeFlag1 = new WinFormsField("OLD-EMPLOYEE-FLAG-1", "OldEmployeeFlag1");
        public static WinFormsField NewEmployeeFlag1 = new WinFormsField("NEW-EMPLOYEE-FLAG-1", "NewEmployeeFlag1");
        public static WinFormsField OldBusinessUnit = new WinFormsField("OLD-BUSINESS-UNIT", "OldBusinessUnit");
        public static WinFormsField NewBusinessUnit = new WinFormsField("NEW-BUSINESS-UNIT", "NewBusinessUnit");
        public static WinFormsField OldEmployeeFlag2 = new WinFormsField("OLD-EMPLOYEE-FLAG-2", "OldEmployeeFlag2");
        public static WinFormsField NewEmployeeFlag2 = new WinFormsField("NEW-EMPLOYEE-FLAG-2", "NewEmployeeFlag2");
        public static WinFormsField OldJobBand = new WinFormsField("OLD-JOB-BAND", "OldJobBand");
        public static WinFormsField NewJobBand = new WinFormsField("NEW-JOB-BAND", "NewJobBand");
        public static WinFormsField OldCostCentre = new WinFormsField("OLD-COST-CENTRE", "OldCostCentre");
        public static WinFormsField NewCostCentre = new WinFormsField("NEW-COST-CENTRE", "NewCostCentre");
        public static WinFormsField OldBlkotRstrctdInd = new WinFormsField("OLD-BLKOT-RSTRCTD-IND", "OldBlkotRstrctdInd");
        public static WinFormsField NewBlkotRstrctdInd = new WinFormsField("NEW-BLKOT-RSTRCTD-IND", "NewBlkotRstrctdInd");
        public static WinFormsField OldEmpCommOffer = new WinFormsField("OLD-EMP-COMM-OFFER", "OldEmpCommOffer");
        public static WinFormsField NewEmpCommOffer = new WinFormsField("NEW-EMP-COMM-OFFER", "NewEmpCommOffer");
        public static WinFormsField OldBlkotRstrctdCode = new WinFormsField("OLD-BLKOT-RSTRCTD-CODE", "OldBlkotRstrctdCode");
        public static WinFormsField NewBlkotRstrctdCode = new WinFormsField("NEW-BLKOT-RSTRCTD-CODE", "NewBlkotRstrctdCode");
        public static WinFormsField OldEmpCommStmnt = new WinFormsField("OLD-EMP-COMM-STMNT", "OldEmpCommStmnt");
        public static WinFormsField NewEmpCommStmnt = new WinFormsField("NEW-EMP-COMM-STMNT", "NewEmpCommStmnt");
        public static WinFormsField OldEmpCommAdhoc = new WinFormsField("OLD-EMP-COMM-ADHOC", "OldEmpCommAdhoc");
        public static WinFormsField NewEmpCommAdhoc = new WinFormsField("NEW-EMP-COMM-ADHOC", "NewEmpCommAdhoc");
        public static WinFormsField OldEmpCommMeeting = new WinFormsField("OLD-EMP-COMM-MEETING", "OldEmpCommMeeting");
        public static WinFormsField NewEmpCommMeeting = new WinFormsField("NEW-EMP-COMM-MEETING", "NewEmpCommMeeting");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
