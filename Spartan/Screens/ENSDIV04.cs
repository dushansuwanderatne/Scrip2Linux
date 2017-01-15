using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIV04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIV04", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField IncomeSource = new WinFormsField("INCOME-SOURCE", "IncomeSource");
        public static WinFormsField SubPayCode = new WinFormsField("SUB-PAY-CODE", "SubPayCode");
        public static WinFormsField SubPayType = new WinFormsField("SUB-PAY-TYPE", "SubPayType");
        public static WinFormsField SubPayDesc = new WinFormsField("SUB-PAY-DESC", "SubPayDesc");
        public static WinFormsField SubPayAccCode = new WinFormsField("SUB-PAY-ACC-CODE", "SubPayAccCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField ClsCode = new WinFormsField("CLS-CODE", "ClsCode");
        public static WinFormsField Slash = new WinFormsField("SLASH", "Slash");
        public static WinFormsField CatCode = new WinFormsField("CAT-CODE", "CatCode");
        public static WinFormsField ClassUnits = new WinFormsField("CLASS-UNITS", "ClassUnits");
        public static WinFormsField PaymentRate = new WinFormsField("PAYMENT-RATE", "PaymentRate");
        public static WinFormsField SelectionNumber = new WinFormsField("SELECTION-NUMBER", "SelectionNumber");
        public static WinFormsField SecAsxCode = new WinFormsField("SEC-ASX-CODE", "SecAsxCode");
        public static WinFormsField Note = new WinFormsField("NOTE", "Note");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
