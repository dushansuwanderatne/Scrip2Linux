using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01116

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01116", "FormName");
		//Fields


        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField ConvertTOAud = new WinFormsField("CONVERT-TO-AUD", "ConvertTOAud");
        public static WinFormsField StoreExchRate = new WinFormsField("STORE-EXCH-RATE", "StoreExchRate");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField ExchCodeDesc = new WinFormsField("EXCH-CODE-DESC", "ExchCodeDesc");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
