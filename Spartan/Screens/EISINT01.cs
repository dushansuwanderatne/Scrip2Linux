using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EISINT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EISINT01", "FormName");
		//Fields


        public static WinFormsField EisintKey0 = new WinFormsField("EISINT-KEY0", "EisintKey0");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField EmpUnits = new WinFormsField("EMP-UNITS", "EmpUnits");
        public static WinFormsField CoyVestedUnits = new WinFormsField("COY-VESTED-UNITS", "CoyVestedUnits");
        public static WinFormsField CoyUnvestedUnits = new WinFormsField("COY-UNVESTED-UNITS", "CoyUnvestedUnits");
        public static WinFormsField EmpContrib = new WinFormsField("EMP-CONTRIB", "EmpContrib");
        public static WinFormsField CoyContrib = new WinFormsField("COY-CONTRIB", "CoyContrib");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
