using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLSTOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLSTOT01", "FormName");
		//Fields


        public static WinFormsField ClstotKey0 = new WinFormsField("CLSTOT-KEY0", "ClstotKey0");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField SubregUnitsC1 = new WinFormsField("SUBREG-UNITS-C1", "SubregUnitsC1");
        public static WinFormsField SubregUnitsC2 = new WinFormsField("SUBREG-UNITS-C2", "SubregUnitsC2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
