using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS31

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS31", "FormName");
		//Fields
        public static WinFormsField DetailLine = new WinFormsField("DETAIL-LINE", "DetailLine");
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField NameAddress = new WinFormsField("NAME-ADDRESS", "NameAddress");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField EmployeeNbr = new WinFormsField("EMPLOYEE-NBR", "EmployeeNbr");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField SubPayrollID = new WinFormsField("SUB-PAYROLL-ID", "SubPayrollID");
        public static WinFormsField EmployeeStatus = new WinFormsField("EMPLOYEE-STATUS", "EmployeeStatus");
        public static WinFormsField EmployeeStatusDesc = new WinFormsField("EMPLOYEE-STATUS-DESC", "EmployeeStatusDesc");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField NationalInsNbr = new WinFormsField("NATIONAL-INS-NBR", "NationalInsNbr");
        public static WinFormsField SchemeCode = new WinFormsField("SCHEME-CODE", "SchemeCode");
        public static WinFormsField SchemeName = new WinFormsField("SCHEME-NAME", "SchemeName");
        public static WinFormsField Leaver1 = new WinFormsField("LEAVER-1", "Leaver1");
        public static WinFormsField Leaver2 = new WinFormsField("LEAVER-2", "Leaver2");
        public static WinFormsField Ignore = new WinFormsField("IGNORE", "Ignore");
        public static WinFormsField TranNumber1 = new WinFormsField("TRAN-NUMBER-1", "TranNumber1");
        public static WinFormsField RegstrCode = new WinFormsField("REGSTR-CODE", "RegstrCode");
        public static WinFormsField RegstrType = new WinFormsField("REGSTR-TYPE", "RegstrType");
        public static WinFormsField GrantDate = new WinFormsField("GRANT-DATE", "GrantDate");
        public static WinFormsField Vesting = new WinFormsField("VESTING", "Vesting");
        public static WinFormsField ProcDate = new WinFormsField("PROC-DATE", "ProcDate");
        public static WinFormsField EffectDate = new WinFormsField("EFFECT-DATE", "EffectDate");
        public static WinFormsField Blackout = new WinFormsField("BLACKOUT", "Blackout");
        public static WinFormsField Run = new WinFormsField("RUN", "Run");
        public static WinFormsField TranNumber2 = new WinFormsField("TRAN-NUMBER-2", "TranNumber2");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
