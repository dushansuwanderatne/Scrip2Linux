using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCBA0902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCBA0902", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ApplicationNumber = new WinFormsField("APPLICATION-NUMBER", "ApplicationNumber");
        public static WinFormsField ReferenceNumber = new WinFormsField("REFERENCE-NUMBER", "ReferenceNumber");
        public static WinFormsField ApplicationTO = new WinFormsField("APPLICATION-TO", "ApplicationTO");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField BankDelete = new WinFormsField("BANK-DELETE", "BankDelete");
        public static WinFormsField MoneyDeposited = new WinFormsField("MONEY-DEPOSITED", "MoneyDeposited");
        public static WinFormsField BranchCode = new WinFormsField("BRANCH-CODE", "BranchCode");
        public static WinFormsField BranchDesc = new WinFormsField("BRANCH-DESC", "BranchDesc");
        public static WinFormsField KeypunchDelete = new WinFormsField("KEYPUNCH-DELETE", "KeypunchDelete");
        public static WinFormsField TransactionNumber = new WinFormsField("TRANSACTION-NUMBER", "TransactionNumber");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField SharesAllocated = new WinFormsField("SHARES-ALLOCATED", "SharesAllocated");
        public static WinFormsField MoneyApplied = new WinFormsField("MONEY-APPLIED", "MoneyApplied");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField EmployeeNumber = new WinFormsField("EMPLOYEE-NUMBER", "EmployeeNumber");
        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField Exception = new WinFormsField("EXCEPTION", "Exception");
        public static WinFormsField Rejection = new WinFormsField("REJECTION", "Rejection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}