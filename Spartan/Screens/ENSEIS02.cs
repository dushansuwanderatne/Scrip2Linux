using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEIS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEIS02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField EmployeeNumber = new WinFormsField("EMPLOYEE-NUMBER", "EmployeeNumber");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderAddress1 = new WinFormsField("HOLDER-ADDRESS-1", "HolderAddress1");
        public static WinFormsField HolderAddress2 = new WinFormsField("HOLDER-ADDRESS-2", "HolderAddress2");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDesc = new WinFormsField("INV-DESC", "InvDesc");
        public static WinFormsField AllotPeriod = new WinFormsField("ALLOT-PERIOD", "AllotPeriod");
        public static WinFormsField DateContrib = new WinFormsField("DATE-CONTRIB", "DateContrib");
        public static WinFormsField RunNbr = new WinFormsField("RUN-NBR", "RunNbr");
        public static WinFormsField Slash = new WinFormsField("SLASH", "Slash");
        public static WinFormsField RefNbr = new WinFormsField("REF-NBR", "RefNbr");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField EmpContrib = new WinFormsField("EMP-CONTRIB", "EmpContrib");
        public static WinFormsField CoyContrib = new WinFormsField("COY-CONTRIB", "CoyContrib");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
