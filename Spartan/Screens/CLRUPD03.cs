using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLRUPD03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLRUPD03", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField Prefix = new WinFormsField("PREFIX", "Prefix");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField CpiIncrease = new WinFormsField("CPI-INCREASE", "CpiIncrease");
        public static WinFormsField TKNotice = new WinFormsField("TK-NOTICE", "TKNotice");
        public static WinFormsField TKHN = new WinFormsField("TK-HN", "TKHN");
        public static WinFormsField AllotRun = new WinFormsField("ALLOT-RUN", "AllotRun");
        public static WinFormsField Recon = new WinFormsField("RECON", "Recon");
        public static WinFormsField HNDiv = new WinFormsField("HN-DIV", "HNDiv");
        public static WinFormsField HNDrp = new WinFormsField("HN-DRP", "HNDrp");
        public static WinFormsField HNPart = new WinFormsField("HN-PART", "HNPart");
        public static WinFormsField HNBspDrp = new WinFormsField("HN-BSP-DRP", "HNBspDrp");
        public static WinFormsField HNSource = new WinFormsField("HN-SOURCE", "HNSource");
        public static WinFormsField MultCurrency = new WinFormsField("MULT-CURRENCY", "MultCurrency");
    }
}
