using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS50

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS50", "FormName");
		//Fields
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransSequence = new WinFormsField("TRANS-SEQUENCE", "TransSequence");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranDate = new WinFormsField("TRAN-DATE", "TranDate");
        public static WinFormsField Timestamp = new WinFormsField("TIMESTAMP", "Timestamp");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField Source = new WinFormsField("SOURCE", "Source");
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
        public static WinFormsField CommentLine = new WinFormsField("COMMENT-LINE", "CommentLine");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField CertificateID = new WinFormsField("CERTIFICATE-ID", "CertificateID");
        public static WinFormsField DetailLine = new WinFormsField("DETAIL-LINE", "DetailLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
