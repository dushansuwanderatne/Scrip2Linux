using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10017

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10017", "FormName");
		//Fields


        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P.  Principal Balance (Brief)", "PrincipalBalance(Brief)");
        public static WinFormsField MenuItemF = new WinFormsField("MENU-ITEM-F", "F.  Full Register List", "FullRegisterList");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RegDetails = new WinFormsField("REG-DETAILS", "RegDetails");
        public static WinFormsField RegEsdPrint = new WinFormsField("REG-ESD-PRINT", "RegEsdPrint");
        public static WinFormsField MovementsTOPrint = new WinFormsField("MOVEMENTS-TO-PRINT", "MovementsTOPrint");
        public static WinFormsField NilCertsTOPrint = new WinFormsField("NIL-CERTS-TO-PRINT", "NilCertsTOPrint");
        public static WinFormsField AustraclearBdown = new WinFormsField("AUSTRACLEAR-BDOWN", "AustraclearBdown");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
