using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RMS01000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RMS01000", "FormName");
		//Fields


        public static WinFormsField ReceiptRoutingID = new WinFormsField("RECEIPT-ROUTING-ID", "ReceiptRoutingID");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField LockboxAppliesInd = new WinFormsField("LOCKBOX-APPLIES-IND", "LockboxAppliesInd");
        public static WinFormsField LockboxNumber = new WinFormsField("LOCKBOX-NUMBER", "LockboxNumber");
        public static WinFormsField BpayAppliesInd = new WinFormsField("BPAY-APPLIES-IND", "BpayAppliesInd");
        public static WinFormsField BillerCode = new WinFormsField("BILLER-CODE", "BillerCode");
        public static WinFormsField DefaultRouteInd = new WinFormsField("DEFAULT-ROUTE-IND", "DefaultRouteInd");
        public static WinFormsField DdbAppliesInd = new WinFormsField("DDB-APPLIES-IND", "DdbAppliesInd");
        public static WinFormsField BankBsb1to3 = new WinFormsField("BANK-BSB-1TO3", "BankBsb1to3");
        public static WinFormsField BankBsb5to7 = new WinFormsField("BANK-BSB-5TO7", "BankBsb5to7");
        public static WinFormsField BankAccount = new WinFormsField("BANK-ACCOUNT", "BankAccount");
        public static WinFormsField ProjectID = new WinFormsField("PROJECT-ID", "ProjectID");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField TransRemitter = new WinFormsField("TRANS-REMITTER", "TransRemitter");
        public static WinFormsField EmailAddress1 = new WinFormsField("EMAIL-ADDRESS1", "EmailAddress1");
        public static WinFormsField EmailAddress2 = new WinFormsField("EMAIL-ADDRESS2", "EmailAddress2");
        public static WinFormsField EmailAddress3 = new WinFormsField("EMAIL-ADDRESS3", "EmailAddress3");
        public static WinFormsField SubsystemCode = new WinFormsField("SUBSYSTEM-CODE", "SubsystemCode");
        public static WinFormsField SubsystemRef = new WinFormsField("SUBSYSTEM-REF", "SubsystemRef");
        public static WinFormsField ExpiredDate = new WinFormsField("EXPIRED-DATE", "ExpiredDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchRoutingID = new WinFormsField("SEARCH-ROUTING-ID", "SearchRoutingID");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
