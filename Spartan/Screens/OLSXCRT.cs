using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSXCRT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSXCRT", "FormName");
		//Fields


        public static WinFormsField LastCert = new WinFormsField("LAST-CERT", "LastCert");
        public static WinFormsField SellCert = new WinFormsField("SELL-CERT", "SellCert");
    }
}
