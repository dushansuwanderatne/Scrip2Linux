using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCHIS01", "FormName");
		//Fields


        public static WinFormsField AcchisKey0 = new WinFormsField("ACCHIS-KEY0", "AcchisKey0");
        public static WinFormsField PaymentSource = new WinFormsField("PAYMENT-SOURCE", "PaymentSource");
        public static WinFormsField UnderpaymentAmount = new WinFormsField("UNDERPAYMENT-AMOUNT", "UnderpaymentAmount");
        public static WinFormsField CrtTransNumber = new WinFormsField("CRT-TRANS-NUMBER", "CrtTransNumber");
        public static WinFormsField OverpaymentAmount = new WinFormsField("OVERPAYMENT-AMOUNT", "OverpaymentAmount");
        public static WinFormsField NOPayments = new WinFormsField("NO-PAYMENTS", "NOPayments");
        public static WinFormsField AcceptanceStatus = new WinFormsField("ACCEPTANCE-STATUS", "AcceptanceStatus");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField AcceptanceSource = new WinFormsField("ACCEPTANCE-SOURCE", "AcceptanceSource");
        public static WinFormsField OriginalEntitlement = new WinFormsField("ORIGINAL-ENTITLEMENT", "OriginalEntitlement");
        public static WinFormsField TimestampDate = new WinFormsField("TIMESTAMP-DATE", "TimestampDate");
        public static WinFormsField EntitledUnits = new WinFormsField("ENTITLED-UNITS", "EntitledUnits");
        public static WinFormsField TimestampTimeHhmmss = new WinFormsField("TIMESTAMP-TIME-HHMMSS", "TimestampTimeHhmmss");
        public static WinFormsField AcceptedUnits = new WinFormsField("ACCEPTED-UNITS", "AcceptedUnits");
        public static WinFormsField AcceptanceLevelMoney = new WinFormsField("ACCEPTANCE-LEVEL-MONEY", "AcceptanceLevelMoney");
        public static WinFormsField AdditionalUnits = new WinFormsField("ADDITIONAL-UNITS", "AdditionalUnits");
        public static WinFormsField LatestTransSource = new WinFormsField("LATEST-TRANS-SOURCE", "LatestTransSource");
        public static WinFormsField OverrideApplyInd = new WinFormsField("OVERRIDE-APPLY-IND", "OverrideApplyInd");
        public static WinFormsField OverrideUnits = new WinFormsField("OVERRIDE-UNITS", "OverrideUnits");
        public static WinFormsField AdditionalMoney = new WinFormsField("ADDITIONAL-MONEY", "AdditionalMoney");
        public static WinFormsField MsbSource = new WinFormsField("MSB-SOURCE", "MsbSource");
        public static WinFormsField MsbNOPayments = new WinFormsField("MSB-NO-PAYMENTS", "MsbNOPayments");
        public static WinFormsField MsbTotalMoney = new WinFormsField("MSB-TOTAL-MONEY", "MsbTotalMoney");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
