using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP20

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP20", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AllAus = new WinFormsField("ALL-AUS", "AllAus");
        public static WinFormsField AllCap = new WinFormsField("ALL-CAP", "AllCap");
        public static WinFormsField AllNsw = new WinFormsField("ALL-NSW", "AllNsw");
        public static WinFormsField AllVic = new WinFormsField("ALL-VIC", "AllVic");
        public static WinFormsField AllQld = new WinFormsField("ALL-QLD", "AllQld");
        public static WinFormsField AllSA = new WinFormsField("ALL-SA", "AllSA");
        public static WinFormsField AllWA = new WinFormsField("ALL-WA", "AllWA");
        public static WinFormsField AllTas = new WinFormsField("ALL-TAS", "AllTas");
    }
}
