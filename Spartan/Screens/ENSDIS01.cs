using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIS01", "FormName");
		//Fields
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField LineNumber = new WinFormsField("LINE-NUMBER", "LineNumber");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField Comments = new WinFormsField("COMMENTS", "Comments");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField RefNumberX = new WinFormsField("REF-NUMBER-X", "RefNumberX");
        public static WinFormsField PaidAmount = new WinFormsField("PAID-AMOUNT", "PaidAmount");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField PresDate = new WinFormsField("PRES-DATE", "PresDate");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField HolderPI = new WinFormsField("HOLDER-PI", "HolderPI");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HnaLine1 = new WinFormsField("HNA-LINE-1", "HnaLine1");
        public static WinFormsField HnaLine2 = new WinFormsField("HNA-LINE-2", "HnaLine2");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
