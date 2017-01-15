using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNKRMT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNKRMT01", "FormName");
		//Fields


        public static WinFormsField BnkrmtKey0 = new WinFormsField("BNKRMT-KEY0", "BnkrmtKey0");
        public static WinFormsField BnkrmtKey1 = new WinFormsField("BNKRMT-KEY1", "BnkrmtKey1");
        public static WinFormsField ReceiptRoutingID = new WinFormsField("RECEIPT-ROUTING-ID", "ReceiptRoutingID");
        public static WinFormsField BillerCode = new WinFormsField("BILLER-CODE", "BillerCode");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField SubsystemID = new WinFormsField("SUBSYSTEM-ID", "SubsystemID");
        public static WinFormsField ExpiredDate = new WinFormsField("EXPIRED-DATE", "ExpiredDate");
        public static WinFormsField ReceiptRoutingIDDesc = new WinFormsField("RECEIPT-ROUTING-ID-DESC", "ReceiptRoutingIDDesc");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        public static WinFormsField LockboxAppliesInd = new WinFormsField("LOCKBOX-APPLIES-IND", "LockboxAppliesInd");
        public static WinFormsField CreatedDate = new WinFormsField("CREATED-DATE", "CreatedDate");
        public static WinFormsField LockboxNumber = new WinFormsField("LOCKBOX-NUMBER", "LockboxNumber");
        public static WinFormsField LastUsedDate = new WinFormsField("LAST-USED-DATE", "LastUsedDate");
        public static WinFormsField BpayAppliesInd = new WinFormsField("BPAY-APPLIES-IND", "BpayAppliesInd");
        public static WinFormsField DataLockedInd = new WinFormsField("DATA-LOCKED-IND", "DataLockedInd");
        public static WinFormsField DefaultRouteInd = new WinFormsField("DEFAULT-ROUTE-IND", "DefaultRouteInd");
        public static WinFormsField DDAppliesInd = new WinFormsField("DD-APPLIES-IND", "DDAppliesInd");
        public static WinFormsField DDBankBsb1to3 = new WinFormsField("DD-BANK-BSB-1TO3", "DDBankBsb1to3");
        public static WinFormsField DDBankBsb5to7 = new WinFormsField("DD-BANK-BSB-5TO7", "DDBankBsb5to7");
        public static WinFormsField DDBankAccount = new WinFormsField("DD-BANK-ACCOUNT", "DDBankAccount");
        public static WinFormsField DDProjectID = new WinFormsField("DD-PROJECT-ID", "DDProjectID");
        public static WinFormsField DDPaymentDesc = new WinFormsField("DD-PAYMENT-DESC", "DDPaymentDesc");
        public static WinFormsField DDTransRemitter = new WinFormsField("DD-TRANS-REMITTER", "DDTransRemitter");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
