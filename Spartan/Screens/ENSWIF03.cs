using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSWIF03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSWIF03", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PayeeNbr = new WinFormsField("PAYEE-NBR", "PayeeNbr");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderNamekey = new WinFormsField("HOLDER-NAMEKEY", "HolderNamekey");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField ClassUnitValue = new WinFormsField("CLASS-UNIT-VALUE", "ClassUnitValue");
        public static WinFormsField Contributions = new WinFormsField("CONTRIBUTIONS", "Contributions");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Value = new WinFormsField("VALUE", "Value");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
