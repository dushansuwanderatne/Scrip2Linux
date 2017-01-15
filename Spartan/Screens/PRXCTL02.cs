using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRXCTL02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRXCTL02", "FormName");
		//Fields


        public static WinFormsField PrxctlKey0 = new WinFormsField("PRXCTL-KEY0", "PrxctlKey0");
        public static WinFormsField BriefDesc = new WinFormsField("BRIEF-DESC", "BriefDesc");
        public static WinFormsField LongDesc = new WinFormsField("LONG-DESC", "LongDesc");
        public static WinFormsField FullDescription = new WinFormsField("FULL-DESCRIPTION", "FullDescription");
        public static WinFormsField PollRes = new WinFormsField("POLL-RES", "PollRes");
        public static WinFormsField DefaultTOChairmanInd = new WinFormsField("DEFAULT-TO-CHAIRMAN-IND", "DefaultTOChairmanInd");
        public static WinFormsField OveRes = new WinFormsField("OVE-RES", "OveRes");
        public static WinFormsField NomOveRes = new WinFormsField("NOM-OVE-RES", "NomOveRes");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField ExcClass = new WinFormsField("EXC-CLASS", "ExcClass");
        public static WinFormsField ClassCodeB = new WinFormsField("CLASS-CODE-B", "ClassCodeB");
        public static WinFormsField ExcClassB = new WinFormsField("EXC-CLASS-B", "ExcClassB");
        public static WinFormsField Rounding = new WinFormsField("ROUNDING", "Rounding");
        public static WinFormsField ExclClassCode = new WinFormsField("EXCL-CLASS-CODE", "ExclClassCode");
        public static WinFormsField UnitsIssuedOS = new WinFormsField("UNITS-ISSUED-OS", "UnitsIssuedOS");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
