using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHMP1010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHMP1010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Aic = new WinFormsField("AIC", "Aic");
        public static WinFormsField Version = new WinFormsField("VERSION", "Version");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Nsn = new WinFormsField("NSN", "Nsn");
        public static WinFormsField SignaleDownload = new WinFormsField("SIGNALE-DOWNLOAD", "SignaleDownload");
        public static WinFormsField SignalgDownload = new WinFormsField("SIGNALG-DOWNLOAD", "SignalgDownload");
        public static WinFormsField TradeDownload = new WinFormsField("TRADE-DOWNLOAD", "TradeDownload");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
