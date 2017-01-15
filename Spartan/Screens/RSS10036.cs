using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10036
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10036", "FormName");
        //Fields
        public static WinFormsField BalanceDetails = new WinFormsField("BALANCE-DETAILS", "BalanceDetails");
        public static WinFormsField ClassTotals = new WinFormsField("CLASS-TOTALS", "ClassTotals");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField CertificateNmbrs = new WinFormsField("CERTIFICATE-NMBRS", "CertificateNmbrs");
        public static WinFormsField GroupTotals = new WinFormsField("GROUP-TOTALS", "GroupTotals");
        public static WinFormsField ReportClassORGroup = new WinFormsField("REPORT-CLASS-OR-GROUP", "ReportClassORGroup");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField RegisterRequired = new WinFormsField("REGISTER-REQUIRED", "RegisterRequired");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField PlanDetails = new WinFormsField("PLAN-DETAILS", "PlanDetails");
        public static WinFormsField DrpDetails = new WinFormsField("DRP-DETAILS", "DrpDetails");
        public static WinFormsField DrpPlanDesc = new WinFormsField("DRP-PLAN-DESC", "DrpPlanDesc");
        public static WinFormsField BspDetails = new WinFormsField("BSP-DETAILS", "BspDetails");
        public static WinFormsField BspPlanDesc = new WinFormsField("BSP-PLAN-DESC", "BspPlanDesc");
        public static WinFormsField DirectCredit = new WinFormsField("DIRECT-CREDIT", "DirectCredit");
        public static WinFormsField ResidencyInd = new WinFormsField("RESIDENCY-IND", "ResidencyInd");
        public static WinFormsField BankID = new WinFormsField("BANK-ID", "BankID");
        public static WinFormsField BankNamadd = new WinFormsField("BANK-NAMADD", "BankNamadd");
        public static WinFormsField BankAccountNbr = new WinFormsField("BANK-ACCOUNT-NBR", "BankAccountNbr");
        public static WinFormsField BankAccountName = new WinFormsField("BANK-ACCOUNT-NAME", "BankAccountName");
        public static WinFormsField PayeeDetails = new WinFormsField("PAYEE-DETAILS", "PayeeDetails");
        public static WinFormsField PayeeAddress = new WinFormsField("PAYEE-ADDRESS", "PayeeAddress");
        public static WinFormsField PayeePcodeDomicile = new WinFormsField("PAYEE-PCODE-DOMICILE", "PayeePcodeDomicile");
        public static WinFormsField ForeignChequeInd = new WinFormsField("FOREIGN-CHEQUE-IND", "ForeignChequeInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", "6", "6");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}