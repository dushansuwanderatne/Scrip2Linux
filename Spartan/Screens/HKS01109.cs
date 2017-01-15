using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01109

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01109", "FormName");
		//Fields


        public static WinFormsField AsxListed = new WinFormsField("ASX-LISTED", "AsxListed");
        public static WinFormsField AsxSecurityCode = new WinFormsField("ASX-SECURITY-CODE", "AsxSecurityCode");
        public static WinFormsField NzseListed = new WinFormsField("NZSE-LISTED", "NzseListed");
        public static WinFormsField NzseSecurityCode = new WinFormsField("NZSE-SECURITY-CODE", "NzseSecurityCode");
        public static WinFormsField LseListed = new WinFormsField("LSE-LISTED", "LseListed");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField CumPrefix = new WinFormsField("CUM-PREFIX", "CumPrefix");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField ExchangeDesc = new WinFormsField("EXCHANGE-DESC", "ExchangeDesc");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
