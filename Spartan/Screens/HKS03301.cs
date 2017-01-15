using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03301", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField BankAccStatusDesc = new WinFormsField("BANK-ACC-STATUS-DESC", "BankAccStatusDesc");
        public static WinFormsField UserIDX = new WinFormsField("USER-ID-X", "UserIDX");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LitAdd = new WinFormsField("LIT-ADD", "LitAdd");
        public static WinFormsField LitSearch = new WinFormsField("LIT-SEARCH", "LitSearch");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField SearchReference = new WinFormsField("SEARCH-REFERENCE", "SearchReference");
        public static WinFormsField ScreenHeader = new WinFormsField("SCREEN-HEADER", "ScreenHeader");
        public static WinFormsField SharedAccountInd = new WinFormsField("SHARED-ACCOUNT-IND", "SharedAccountInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
