using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01064

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01064", "FormName");
		//Fields


        public static WinFormsField UserOrigin = new WinFormsField("USER-ORIGIN", "UserOrigin");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField OutputIdentifier = new WinFormsField("OUTPUT-IDENTIFIER", "OutputIdentifier");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField RequestFormCode = new WinFormsField("REQUEST-FORM-CODE", "RequestFormCode");
        public static WinFormsField RequestSource = new WinFormsField("REQUEST-SOURCE", "RequestSource");
        public static WinFormsField ClassCode1to10 = new WinFormsField("CLASS-CODE-1TO10", "ClassCode1to10");
        public static WinFormsField ClassCode11to20 = new WinFormsField("CLASS-CODE-11TO20", "ClassCode11to20");
        public static WinFormsField BalancesASATRun = new WinFormsField("BALANCES-AS-AT-RUN", "BalancesASATRun");
    }
}
