using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSPLBS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSPLBS", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField CostOFShares = new WinFormsField("COST-OF-SHARES", "CostOFShares");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField BulkReference = new WinFormsField("BULK-REFERENCE", "BulkReference");
        public static WinFormsField Charges = new WinFormsField("CHARGES", "Charges");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField ExerciseAmount = new WinFormsField("EXERCISE-AMOUNT", "ExerciseAmount");
        public static WinFormsField SettleDate = new WinFormsField("SETTLE-DATE", "SettleDate");
        public static WinFormsField NettCost = new WinFormsField("NETT-COST", "NettCost");
        public static WinFormsField PayAccount = new WinFormsField("PAY-ACCOUNT", "PayAccount");
        public static WinFormsField Price = new WinFormsField("PRICE", "Price");
        public static WinFormsField PayRefNumber = new WinFormsField("PAY-REF-NUMBER", "PayRefNumber");
        public static WinFormsField PayMethod = new WinFormsField("PAY-METHOD", "PayMethod");
        public static WinFormsField Commission = new WinFormsField("COMMISSION", "Commission");
        public static WinFormsField BankSystem = new WinFormsField("BANK-SYSTEM", "BankSystem");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField StampDuty = new WinFormsField("STAMP-DUTY", "StampDuty");
        public static WinFormsField BankAcctNumber = new WinFormsField("BANK-ACCT-NUMBER", "BankAcctNumber");
        public static WinFormsField OtherCharges = new WinFormsField("OTHER-CHARGES", "OtherCharges");
        public static WinFormsField RegCode1to5 = new WinFormsField("REG-CODE-1TO5", "RegCode1to5");
        public static WinFormsField Units1to5 = new WinFormsField("UNITS-1TO5", "Units1to5");
        public static WinFormsField RegCode6to10 = new WinFormsField("REG-CODE-6TO10", "RegCode6to10");
        public static WinFormsField Units6to10 = new WinFormsField("UNITS-6TO10", "Units6to10");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField PayeeAccountType = new WinFormsField("PAYEE-ACCOUNT-TYPE", "PayeeAccountType");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
