using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00127

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00127", "FormName");
		//Fields


        public static WinFormsField MenuItemEsrrc = new WinFormsField("MENU-ITEM-ESRRC", "ESRRC. Release Residual to Company", "ReleaseResidualtoCompany");
        public static WinFormsField MenuItemEsrrt = new WinFormsField("MENU-ITEM-ESRRT", "ESRRT. Release Residual to Third Party", "ReleaseResidualtoThirdParty");
        public static WinFormsField MenuItemEsrrp = new WinFormsField("MENU-ITEM-ESRRP", "ESRRP. Release Residual to Payroll", "ReleaseResidualtoPayroll");
        public static WinFormsField MenuItemEsrri = new WinFormsField("MENU-ITEM-ESRRI", "ESRRI. Release Residual to Individual", "ReleaseResidualtoIndividual");
        public static WinFormsField MenuItemEsrra = new WinFormsField("MENU-ITEM-ESRRA", "ESRRA. Rollover Residual to New Award", "RolloverResidualtoNewAward");
        public static WinFormsField MenuItemEsrvq = new WinFormsField("MENU-ITEM-ESRVQ", "ESRVQ. Release Residual Reversal", "ReleaseResidualReversal");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
