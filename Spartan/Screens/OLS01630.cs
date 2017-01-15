using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01630

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01630", "FormName");
		//Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderNamKey = new WinFormsField("HOLDER-NAM-KEY", "HolderNamKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField LoadFin = new WinFormsField("LOAD-FIN", "LoadFin");
        public static WinFormsField ValidateFin = new WinFormsField("VALIDATE-FIN", "ValidateFin");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}