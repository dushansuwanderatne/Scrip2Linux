using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAS01004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAS01004", "FormName");
		//Fields


        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField LstSelection = new WinFormsField("LST-SELECTION", "LstSelection");
        public static WinFormsField LstCurrencyCode = new WinFormsField("LST-CURRENCY-CODE", "LstCurrencyCode");
        public static WinFormsField LstBankType = new WinFormsField("LST-BANK-TYPE", "LstBankType");
        public static WinFormsField LstBankCode = new WinFormsField("LST-BANK-CODE", "LstBankCode");
        public static WinFormsField LstAccountNumber = new WinFormsField("LST-ACCOUNT-NUMBER", "LstAccountNumber");
        public static WinFormsField LstUserID = new WinFormsField("LST-USER-ID", "LstUserID");
        public static WinFormsField LstReconcBYFlg = new WinFormsField("LST-RECONC-BY-FLG", "LstReconcBYFlg");
        public static WinFormsField LstAccReconcInd = new WinFormsField("LST-ACC-RECONC-IND", "LstAccReconcInd");
        public static WinFormsField LstDCAllowedInd = new WinFormsField("LST-DC-ALLOWED-IND", "LstDCAllowedInd");
        public static WinFormsField SharedAccountInd = new WinFormsField("SHARED-ACCOUNT-IND", "SharedAccountInd");
        public static WinFormsField LineSelectionX = new WinFormsField("LINE-SELECTION-X", "LineSelectionX");
        public static WinFormsField COBankType = new WinFormsField("CO-BANK-TYPE", "COBankType");
        public static WinFormsField COBankCode = new WinFormsField("CO-BANK-CODE", "COBankCode");
        public static WinFormsField COAccountNumber = new WinFormsField("CO-ACCOUNT-NUMBER", "COAccountNumber");
        public static WinFormsField CRBankType = new WinFormsField("CR-BANK-TYPE", "CRBankType");
        public static WinFormsField CRBankCode = new WinFormsField("CR-BANK-CODE", "CRBankCode");
        public static WinFormsField CRAccountNumber = new WinFormsField("CR-ACCOUNT-NUMBER", "CRAccountNumber");
        public static WinFormsField DOBankType = new WinFormsField("DO-BANK-TYPE", "DOBankType");
        public static WinFormsField DOBankCode = new WinFormsField("DO-BANK-CODE", "DOBankCode");
        public static WinFormsField DOAccountNumber = new WinFormsField("DO-ACCOUNT-NUMBER", "DOAccountNumber");
        public static WinFormsField DRBankType = new WinFormsField("DR-BANK-TYPE", "DRBankType");
        public static WinFormsField DRBankCode = new WinFormsField("DR-BANK-CODE", "DRBankCode");
        public static WinFormsField DRAccountNumber = new WinFormsField("DR-ACCOUNT-NUMBER", "DRAccountNumber");
        public static WinFormsField DcrReplaceType = new WinFormsField("DCR-REPLACE-TYPE", "DcrReplaceType");
        public static WinFormsField FOBankType = new WinFormsField("FO-BANK-TYPE", "FOBankType");
        public static WinFormsField FOBankCode = new WinFormsField("FO-BANK-CODE", "FOBankCode");
        public static WinFormsField FOAccountNumber = new WinFormsField("FO-ACCOUNT-NUMBER", "FOAccountNumber");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
