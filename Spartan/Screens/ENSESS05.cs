using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS05", "FormName");
		//Fields
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransSequence = new WinFormsField("TRANS-SEQUENCE", "TransSequence");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField OffHin = new WinFormsField("OFF-HIN", "OffHin");
        public static WinFormsField OffUsan = new WinFormsField("OFF-USAN", "OffUsan");
        public static WinFormsField ONHin = new WinFormsField("ON-HIN", "ONHin");
        public static WinFormsField ONUsan = new WinFormsField("ON-USAN", "ONUsan");
        public static WinFormsField OffEmployeeID = new WinFormsField("OFF-EMPLOYEE-ID", "OffEmployeeID");
        public static WinFormsField OffPayrollID = new WinFormsField("OFF-PAYROLL-ID", "OffPayrollID");
        public static WinFormsField ONEmployeeID = new WinFormsField("ON-EMPLOYEE-ID", "ONEmployeeID");
        public static WinFormsField ONPayrollID = new WinFormsField("ON-PAYROLL-ID", "ONPayrollID");
        public static WinFormsField OffNINbr = new WinFormsField("OFF-NI-NBR", "OffNINbr");
        public static WinFormsField ONNINbr = new WinFormsField("ON-NI-NBR", "ONNINbr");
        public static WinFormsField OffAddressLine = new WinFormsField("OFF-ADDRESS-LINE", "OffAddressLine");
        public static WinFormsField ONAddressLine = new WinFormsField("ON-ADDRESS-LINE", "ONAddressLine");
        public static WinFormsField OffClass = new WinFormsField("OFF-CLASS", "OffClass");
        public static WinFormsField OffReg = new WinFormsField("OFF-REG", "OffReg");
        public static WinFormsField OffCertID = new WinFormsField("OFF-CERT-ID", "OffCertID");
        public static WinFormsField ONClass = new WinFormsField("ON-CLASS", "ONClass");
        public static WinFormsField ONReg = new WinFormsField("ON-REG", "ONReg");
        public static WinFormsField ONCertID = new WinFormsField("ON-CERT-ID", "ONCertID");
        public static WinFormsField OffUnitDesc = new WinFormsField("OFF-UNIT-DESC", "OffUnitDesc");
        public static WinFormsField OffUnitValue = new WinFormsField("OFF-UNIT-VALUE", "OffUnitValue");
        public static WinFormsField TranDate = new WinFormsField("TRAN-DATE", "TranDate");
        public static WinFormsField ONUnitDesc = new WinFormsField("ON-UNIT-DESC", "ONUnitDesc");
        public static WinFormsField ONUnitValue = new WinFormsField("ON-UNIT-VALUE", "ONUnitValue");
        public static WinFormsField OffDesc = new WinFormsField("OFF-DESC", "OffDesc");
        public static WinFormsField OffValue = new WinFormsField("OFF-VALUE", "OffValue");
        public static WinFormsField ONDesc = new WinFormsField("ON-DESC", "ONDesc");
        public static WinFormsField ONValue = new WinFormsField("ON-VALUE", "ONValue");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
