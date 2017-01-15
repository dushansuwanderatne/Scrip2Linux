using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS24003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS24003", "FormName");
		//Fields


        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField BulkProcessType = new WinFormsField("BULK-PROCESS-TYPE", "BulkProcessType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TransactionSource = new WinFormsField("TRANSACTION-SOURCE", "TransactionSource");
        public static WinFormsField AuditInd = new WinFormsField("AUDIT-IND", "AuditInd");
        public static WinFormsField AuditSettlingTrans = new WinFormsField("AUDIT-SETTLING-TRANS", "AuditSettlingTrans");
        public static WinFormsField AllowCorporateBodies = new WinFormsField("ALLOW-CORPORATE-BODIES", "AllowCorporateBodies");
        public static WinFormsField AllowForeignResident = new WinFormsField("ALLOW-FOREIGN-RESIDENT", "AllowForeignResident");
        public static WinFormsField AllowReturnMail = new WinFormsField("ALLOW-RETURN-MAIL", "AllowReturnMail");
        public static WinFormsField AllowDeceased = new WinFormsField("ALLOW-DECEASED", "AllowDeceased");
        public static WinFormsField AllowPartialSell = new WinFormsField("ALLOW-PARTIAL-SELL", "AllowPartialSell");
        public static WinFormsField SettlementCountry = new WinFormsField("SETTLEMENT-COUNTRY", "SettlementCountry");
        public static WinFormsField SettlementProgram = new WinFormsField("SETTLEMENT-PROGRAM", "SettlementProgram");
        public static WinFormsField GenerateAdvices = new WinFormsField("GENERATE-ADVICES", "GenerateAdvices");
        public static WinFormsField AdviceProgram = new WinFormsField("ADVICE-PROGRAM", "AdviceProgram");
        public static WinFormsField GenerateCertificates = new WinFormsField("GENERATE-CERTIFICATES", "GenerateCertificates");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
