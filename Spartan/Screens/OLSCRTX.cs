using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTX

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTX", "FormName");
		//Fields


        public static WinFormsField LastCert = new WinFormsField("LAST-CERT", "LastCert");
        public static WinFormsField SubTotal = new WinFormsField("SUB-TOTAL", "SubTotal");
        public static WinFormsField SellCert = new WinFormsField("SELL-CERT", "SellCert");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
    }
}
