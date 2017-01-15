using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL02902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL02902", "FormName");
		//Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDescription = new WinFormsField("EVENT-DESCRIPTION", "EventDescription");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField WthldgTaxRate1 = new WinFormsField("WTHLDG-TAX-RATE-1", "WthldgTaxRate1");
        public static WinFormsField WthldgTaxCode1 = new WinFormsField("WTHLDG-TAX-CODE-1", "WthldgTaxCode1");
        public static WinFormsField MktValueType1 = new WinFormsField("MKT-VALUE-TYPE-1", "MktValueType1");
        public static WinFormsField CmplxHldrCode1 = new WinFormsField("CMPLX-HLDR-CODE-1", "CmplxHldrCode1");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField WthldgTaxRate2 = new WinFormsField("WTHLDG-TAX-RATE-2", "WthldgTaxRate2");
        public static WinFormsField WthldgTaxCode2 = new WinFormsField("WTHLDG-TAX-CODE-2", "WthldgTaxCode2");
        public static WinFormsField MktValueType2 = new WinFormsField("MKT-VALUE-TYPE-2", "MktValueType2");
        public static WinFormsField CmplxHldrCode2 = new WinFormsField("CMPLX-HLDR-CODE-2", "CmplxHldrCode2");
        public static WinFormsField WthldgTaxRate3 = new WinFormsField("WTHLDG-TAX-RATE-3", "WthldgTaxRate3");
        public static WinFormsField WthldgTaxCode3 = new WinFormsField("WTHLDG-TAX-CODE-3", "WthldgTaxCode3");
        public static WinFormsField MktValueType3 = new WinFormsField("MKT-VALUE-TYPE-3", "MktValueType3");
        public static WinFormsField CmplxHldrCode3 = new WinFormsField("CMPLX-HLDR-CODE-3", "CmplxHldrCode3");
        public static WinFormsField WthldgTaxRate4 = new WinFormsField("WTHLDG-TAX-RATE-4", "WthldgTaxRate4");
        public static WinFormsField WthldgTaxCode4 = new WinFormsField("WTHLDG-TAX-CODE-4", "WthldgTaxCode4");
        public static WinFormsField MktValueType4 = new WinFormsField("MKT-VALUE-TYPE-4", "MktValueType4");
        public static WinFormsField CmplxHldrCode4 = new WinFormsField("CMPLX-HLDR-CODE-4", "CmplxHldrCode4");
        public static WinFormsField WthldgTaxRate5 = new WinFormsField("WTHLDG-TAX-RATE-5", "WthldgTaxRate5");
        public static WinFormsField WthldgTaxCode5 = new WinFormsField("WTHLDG-TAX-CODE-5", "WthldgTaxCode5");
        public static WinFormsField MktValueType5 = new WinFormsField("MKT-VALUE-TYPE-5", "MktValueType5");
        public static WinFormsField CmplxHldrCode5 = new WinFormsField("CMPLX-HLDR-CODE-5", "CmplxHldrCode5");
        public static WinFormsField WthldgTaxRate6 = new WinFormsField("WTHLDG-TAX-RATE-6", "WthldgTaxRate6");
        public static WinFormsField WthldgTaxCode6 = new WinFormsField("WTHLDG-TAX-CODE-6", "WthldgTaxCode6");
        public static WinFormsField MktValueType6 = new WinFormsField("MKT-VALUE-TYPE-6", "MktValueType6");
        public static WinFormsField CmplxHldrCode6 = new WinFormsField("CMPLX-HLDR-CODE-6", "CmplxHldrCode6");
        public static WinFormsField WthldgTaxRate7 = new WinFormsField("WTHLDG-TAX-RATE-7", "WthldgTaxRate7");
        public static WinFormsField WthldgTaxCode7 = new WinFormsField("WTHLDG-TAX-CODE-7", "WthldgTaxCode7");
        public static WinFormsField MktValueType7 = new WinFormsField("MKT-VALUE-TYPE-7", "MktValueType7");
        public static WinFormsField CmplxHldrCode7 = new WinFormsField("CMPLX-HLDR-CODE-7", "CmplxHldrCode7");
        public static WinFormsField WthldgTaxRate8 = new WinFormsField("WTHLDG-TAX-RATE-8", "WthldgTaxRate8");
        public static WinFormsField WthldgTaxCode8 = new WinFormsField("WTHLDG-TAX-CODE-8", "WthldgTaxCode8");
        public static WinFormsField MktValueType8 = new WinFormsField("MKT-VALUE-TYPE-8", "MktValueType8");
        public static WinFormsField CmplxHldrCode8 = new WinFormsField("CMPLX-HLDR-CODE-8", "CmplxHldrCode8");
        public static WinFormsField WthldgTaxRate9 = new WinFormsField("WTHLDG-TAX-RATE-9", "WthldgTaxRate9");
        public static WinFormsField WthldgTaxCode9 = new WinFormsField("WTHLDG-TAX-CODE-9", "WthldgTaxCode9");
        public static WinFormsField MktValueType9 = new WinFormsField("MKT-VALUE-TYPE-9", "MktValueType9");
        public static WinFormsField CmplxHldrCode9 = new WinFormsField("CMPLX-HLDR-CODE-9", "CmplxHldrCode9");
        public static WinFormsField WthldgTaxRate10 = new WinFormsField("WTHLDG-TAX-RATE-10", "WthldgTaxRate10");
        public static WinFormsField WthldgTaxCode10 = new WinFormsField("WTHLDG-TAX-CODE-10", "WthldgTaxCode10");
        public static WinFormsField MktValueType10 = new WinFormsField("MKT-VALUE-TYPE-10", "MktValueType10");
        public static WinFormsField CmplxHldrCode10 = new WinFormsField("CMPLX-HLDR-CODE-10", "CmplxHldrCode10");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
