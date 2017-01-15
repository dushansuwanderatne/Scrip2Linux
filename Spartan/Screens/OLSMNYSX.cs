using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSMNYSX

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSMNYSX", "FormName");
		//Fields


        public static WinFormsField LastCert = new WinFormsField("LAST-CERT", "LastCert");
        public static WinFormsField SubTotal = new WinFormsField("SUB-TOTAL", "SubTotal");
        public static WinFormsField SellCert = new WinFormsField("SELL-CERT", "SellCert");
        public static WinFormsField SellMoney = new WinFormsField("SELL-MONEY", "SellMoney");
    }
}
