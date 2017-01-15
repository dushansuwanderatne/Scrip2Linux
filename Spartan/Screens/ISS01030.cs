using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISS01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISS01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField NBOff2HeldOpt = new WinFormsField("NB-OFF2-HELD-OPT", "NBOff2HeldOpt");
        public static WinFormsField NBOff2X = new WinFormsField("NB-OFF2-X", "NBOff2X");
        public static WinFormsField NBOff2Y = new WinFormsField("NB-OFF2-Y", "NBOff2Y");
        public static WinFormsField NBOff2PayA = new WinFormsField("NB-OFF2-PAY-A", "NBOff2PayA");
        public static WinFormsField NBOff2PayB = new WinFormsField("NB-OFF2-PAY-B", "NBOff2PayB");
        public static WinFormsField NBOff2CalcMethod = new WinFormsField("NB-OFF2-CALC-METHOD", "NBOff2CalcMethod");
        public static WinFormsField NBOff2RoundOpt = new WinFormsField("NB-OFF2-ROUND-OPT", "NBOff2RoundOpt");
        public static WinFormsField NBOff2Multiple = new WinFormsField("NB-OFF2-MULTIPLE", "NBOff2Multiple");
        public static WinFormsField NBOff2MinEnt = new WinFormsField("NB-OFF2-MIN-ENT", "NBOff2MinEnt");
        public static WinFormsField NBOff2EntClass = new WinFormsField("NB-OFF2-ENT-CLASS", "NBOff2EntClass");
        public static WinFormsField NBOff2AccClass = new WinFormsField("NB-OFF2-ACC-CLASS", "NBOff2AccClass");
        public static WinFormsField NBOff2EntReg = new WinFormsField("NB-OFF2-ENT-REG", "NBOff2EntReg");
        public static WinFormsField NBOff2FractionCL = new WinFormsField("NB-OFF2-FRACTION-CL", "NBOff2FractionCL");
        public static WinFormsField IssueOutput = new WinFormsField("ISSUE-OUTPUT", "IssueOutput");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
