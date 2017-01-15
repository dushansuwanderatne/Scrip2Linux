using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS12402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS12402", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddrLine = new WinFormsField("ADDR-LINE", "AddrLine");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField ClassLiteral = new WinFormsField("CLASS-LITERAL", "ClassLiteral");
        public static WinFormsField UnitLiteral = new WinFormsField("UNIT-LITERAL", "UnitLiteral");
        public static WinFormsField GrsAmt1Lit1 = new WinFormsField("GRS-AMT1-LIT1", "GrsAmt1Lit1");
        public static WinFormsField GrsAmt2Lit1 = new WinFormsField("GRS-AMT2-LIT1", "GrsAmt2Lit1");
        public static WinFormsField GrsAmt3Lit1 = new WinFormsField("GRS-AMT3-LIT1", "GrsAmt3Lit1");
        public static WinFormsField ImpCredtLit1 = new WinFormsField("IMP-CREDT-LIT1", "ImpCredtLit1");
        public static WinFormsField GrsLiteral1 = new WinFormsField("GRS-LITERAL1", "GrsLiteral1");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField ClassCatUnits = new WinFormsField("CLASS-CAT-UNITS", "ClassCatUnits");
        public static WinFormsField GrossAmt1 = new WinFormsField("GROSS-AMT1", "GrossAmt1");
        public static WinFormsField GrossAmt2 = new WinFormsField("GROSS-AMT2", "GrossAmt2");
        public static WinFormsField GrossAmt3 = new WinFormsField("GROSS-AMT3", "GrossAmt3");
        public static WinFormsField ImputedCredit = new WinFormsField("IMPUTED-CREDIT", "ImputedCredit");
        public static WinFormsField TotalGross = new WinFormsField("TOTAL-GROSS", "TotalGross");
        public static WinFormsField TotGross = new WinFormsField("TOT-GROSS", "TotGross");
        public static WinFormsField TotNett = new WinFormsField("TOT-NETT", "TotNett");
        public static WinFormsField TotTaxAmt = new WinFormsField("TOT-TAX-AMT", "TotTaxAmt");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
