using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIS07

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIS07", "FormName");
		//Fields


        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField SearchReference = new WinFormsField("SEARCH-REFERENCE", "SearchReference");
        public static WinFormsField SearchPayMethod = new WinFormsField("SEARCH-PAY-METHOD", "SearchPayMethod");
        public static WinFormsField SelectionX = new WinFormsField("SELECTION-X", "SelectionX");
        public static WinFormsField HolderIdentifier01 = new WinFormsField("HOLDER-IDENTIFIER-01", "HolderIdentifier01");
        public static WinFormsField HolderNameKey01 = new WinFormsField("HOLDER-NAME-KEY-01", "HolderNameKey01");
        public static WinFormsField BankDetails01 = new WinFormsField("BANK-DETAILS-01", "BankDetails01");
        public static WinFormsField PaidCurrency01 = new WinFormsField("PAID-CURRENCY-01", "PaidCurrency01");
        public static WinFormsField PayAccount01 = new WinFormsField("PAY-ACCOUNT-01", "PayAccount01");
        public static WinFormsField AccountDesc01 = new WinFormsField("ACCOUNT-DESC-01", "AccountDesc01");
        public static WinFormsField ChequeAmount01 = new WinFormsField("CHEQUE-AMOUNT-01", "ChequeAmount01");
        public static WinFormsField PaidDate01 = new WinFormsField("PAID-DATE-01", "PaidDate01");
        public static WinFormsField PresDate01 = new WinFormsField("PRES-DATE-01", "PresDate01");
        public static WinFormsField Status01 = new WinFormsField("STATUS-01", "Status01");
        public static WinFormsField Comments01 = new WinFormsField("COMMENTS-01", "Comments01");
        public static WinFormsField HolderIdentifier02 = new WinFormsField("HOLDER-IDENTIFIER-02", "HolderIdentifier02");
        public static WinFormsField HolderNameKey02 = new WinFormsField("HOLDER-NAME-KEY-02", "HolderNameKey02");
        public static WinFormsField BankDetails02 = new WinFormsField("BANK-DETAILS-02", "BankDetails02");
        public static WinFormsField PaidCurrency02 = new WinFormsField("PAID-CURRENCY-02", "PaidCurrency02");
        public static WinFormsField PayAccount02 = new WinFormsField("PAY-ACCOUNT-02", "PayAccount02");
        public static WinFormsField AccountDesc02 = new WinFormsField("ACCOUNT-DESC-02", "AccountDesc02");
        public static WinFormsField ChequeAmount02 = new WinFormsField("CHEQUE-AMOUNT-02", "ChequeAmount02");
        public static WinFormsField PaidDate02 = new WinFormsField("PAID-DATE-02", "PaidDate02");
        public static WinFormsField PresDate02 = new WinFormsField("PRES-DATE-02", "PresDate02");
        public static WinFormsField Status02 = new WinFormsField("STATUS-02", "Status02");
        public static WinFormsField Comments02 = new WinFormsField("COMMENTS-02", "Comments02");
        public static WinFormsField HolderIdentifier03 = new WinFormsField("HOLDER-IDENTIFIER-03", "HolderIdentifier03");
        public static WinFormsField HolderNameKey03 = new WinFormsField("HOLDER-NAME-KEY-03", "HolderNameKey03");
        public static WinFormsField BankDetails03 = new WinFormsField("BANK-DETAILS-03", "BankDetails03");
        public static WinFormsField PaidCurrency03 = new WinFormsField("PAID-CURRENCY-03", "PaidCurrency03");
        public static WinFormsField PayAccount03 = new WinFormsField("PAY-ACCOUNT-03", "PayAccount03");
        public static WinFormsField AccountDesc03 = new WinFormsField("ACCOUNT-DESC-03", "AccountDesc03");
        public static WinFormsField ChequeAmount03 = new WinFormsField("CHEQUE-AMOUNT-03", "ChequeAmount03");
        public static WinFormsField PaidDate03 = new WinFormsField("PAID-DATE-03", "PaidDate03");
        public static WinFormsField PresDate03 = new WinFormsField("PRES-DATE-03", "PresDate03");
        public static WinFormsField Status03 = new WinFormsField("STATUS-03", "Status03");
        public static WinFormsField Comments03 = new WinFormsField("COMMENTS-03", "Comments03");
        public static WinFormsField HolderIdentifier04 = new WinFormsField("HOLDER-IDENTIFIER-04", "HolderIdentifier04");
        public static WinFormsField HolderNameKey04 = new WinFormsField("HOLDER-NAME-KEY-04", "HolderNameKey04");
        public static WinFormsField BankDetails04 = new WinFormsField("BANK-DETAILS-04", "BankDetails04");
        public static WinFormsField PaidCurrency04 = new WinFormsField("PAID-CURRENCY-04", "PaidCurrency04");
        public static WinFormsField PayAccount04 = new WinFormsField("PAY-ACCOUNT-04", "PayAccount04");
        public static WinFormsField AccountDesc04 = new WinFormsField("ACCOUNT-DESC-04", "AccountDesc04");
        public static WinFormsField ChequeAmount04 = new WinFormsField("CHEQUE-AMOUNT-04", "ChequeAmount04");
        public static WinFormsField PaidDate04 = new WinFormsField("PAID-DATE-04", "PaidDate04");
        public static WinFormsField PresDate04 = new WinFormsField("PRES-DATE-04", "PresDate04");
        public static WinFormsField Status04 = new WinFormsField("STATUS-04", "Status04");
        public static WinFormsField Comments04 = new WinFormsField("COMMENTS-04", "Comments04");
        public static WinFormsField HolderIdentifier05 = new WinFormsField("HOLDER-IDENTIFIER-05", "HolderIdentifier05");
        public static WinFormsField HolderNameKey05 = new WinFormsField("HOLDER-NAME-KEY-05", "HolderNameKey05");
        public static WinFormsField BankDetails05 = new WinFormsField("BANK-DETAILS-05", "BankDetails05");
        public static WinFormsField PaidCurrency05 = new WinFormsField("PAID-CURRENCY-05", "PaidCurrency05");
        public static WinFormsField PayAccount05 = new WinFormsField("PAY-ACCOUNT-05", "PayAccount05");
        public static WinFormsField AccountDesc05 = new WinFormsField("ACCOUNT-DESC-05", "AccountDesc05");
        public static WinFormsField ChequeAmount05 = new WinFormsField("CHEQUE-AMOUNT-05", "ChequeAmount05");
        public static WinFormsField PaidDate05 = new WinFormsField("PAID-DATE-05", "PaidDate05");
        public static WinFormsField PresDate05 = new WinFormsField("PRES-DATE-05", "PresDate05");
        public static WinFormsField Status05 = new WinFormsField("STATUS-05", "Status05");
        public static WinFormsField Comments05 = new WinFormsField("COMMENTS-05", "Comments05");
        public static WinFormsField HolderIdentifier06 = new WinFormsField("HOLDER-IDENTIFIER-06", "HolderIdentifier06");
        public static WinFormsField HolderNameKey06 = new WinFormsField("HOLDER-NAME-KEY-06", "HolderNameKey06");
        public static WinFormsField BankDetails06 = new WinFormsField("BANK-DETAILS-06", "BankDetails06");
        public static WinFormsField PaidCurrency06 = new WinFormsField("PAID-CURRENCY-06", "PaidCurrency06");
        public static WinFormsField PayAccount06 = new WinFormsField("PAY-ACCOUNT-06", "PayAccount06");
        public static WinFormsField AccountDesc06 = new WinFormsField("ACCOUNT-DESC-06", "AccountDesc06");
        public static WinFormsField ChequeAmount06 = new WinFormsField("CHEQUE-AMOUNT-06", "ChequeAmount06");
        public static WinFormsField PaidDate06 = new WinFormsField("PAID-DATE-06", "PaidDate06");
        public static WinFormsField PresDate06 = new WinFormsField("PRES-DATE-06", "PresDate06");
        public static WinFormsField Status06 = new WinFormsField("STATUS-06", "Status06");
        public static WinFormsField Comments06 = new WinFormsField("COMMENTS-06", "Comments06");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
